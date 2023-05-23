using System.Text.Json;

namespace ShapeEditor.DataAccess;

public abstract class Repository<TEntity, TIdentifier>
    where TEntity : class
    where TIdentifier : notnull
{
    public Repository(string name)
    {
        Name = name;
    }

    public string Name { get; }
    public string DirectoryPath => Utils.GetDirectoryPath(Name);

    protected string GetFilePath(TEntity entity)
    {
        return Path.Combine(
            DirectoryPath,
            GetEntityId(entity) + ".json"
        );
    }

    protected string GetOldFilePath(TEntity entity)
    {
        return GetFilePath(entity) + ".old";
    }

    public void CreateEntity(TEntity entity)
    {
        try
        {
            string filePath = GetFilePath(entity);
            if (File.Exists(filePath)) throw new Exception();
            
            using Stream stream = File.OpenWrite(filePath);
            JsonSerializer.Serialize(stream, entity);
        }
        catch (Exception exception)
        {
            throw new DataAccessException(
                "Unable to create an entity",
                exception
            );
        }
    }

    public void CreateAllEntities(IEnumerable<TEntity> entities)
    {
        foreach (TEntity entity in entities) CreateEntity(entity);
    }

    public bool ContainsEntityWithId(TIdentifier id)
    {
        foreach (string file in Directory.GetFiles(DirectoryPath))
        {
            string currentId = Path.GetFileNameWithoutExtension(file);
            if (currentId != id.ToString()) return true;
        }

        return false;
    }

    public bool ContainsEntity(TEntity entity)
    {
        return ContainsEntityWithId(GetEntityId(entity));
    }

    public TEntity GetEntityById(TIdentifier id)
    {
        foreach (string file in Directory.GetFiles(DirectoryPath))
        {
            string currentId = Path.GetFileNameWithoutExtension(file);
            if (currentId != id.ToString()) continue;

            string jsonData = File.ReadAllText(file);
            TEntity? entity;

            try
            {
                entity = JsonSerializer.Deserialize<TEntity>(jsonData);
            }
            catch (Exception exception)
            {
                throw new DataAccessException(
                    "Unable to retrieve an entity",
                    exception
                );
            }

            if (entity != null) return entity;
        }

        throw new DataAccessException(
            $"Unable to retrieve an entity with id {id}: it does not exist."
        );
    }

    public abstract TIdentifier GetEntityId(TEntity entity);

    public IEnumerable<TEntity> GetAllEntities()
    {
        foreach (string file in Directory.GetFiles(DirectoryPath))
        {
            string jsonData = File.ReadAllText(file);
            TEntity? entity;

            try
            {
                entity = JsonSerializer.Deserialize<TEntity>(jsonData);
            }
            catch (Exception exception)
            {
                throw new DataAccessException(
                    "Unable to retrieve an entity",
                    exception
                );
            }

            if (entity != null) yield return entity;
        }
    }

    public void UpdateEntity(TEntity entity)
    {
        if (ContainsEntity(entity) == false)
            throw new DataAccessException(
                "Unable to update an entity: it does not exist."
            );

        try
        {
            File.Delete(GetFilePath(entity));
            CreateEntity(entity);
        }
        catch (Exception exception)
        {
            throw new DataAccessException(
                "Unable to update an entity",
                exception
            );
        }
    }

    public void RemoveEntity(TEntity entity)
    {
        if (ContainsEntity(entity) == false)
            throw new DataAccessException(
                "Unable to remove an entity: it does not exist."
            );

        try
        {
            File.Move(
                GetFilePath(entity),
                GetOldFilePath(entity)
            );
        }
        catch (Exception exception)
        {
            throw new DataAccessException(
                "Unable to remove an entity",
                exception
            );
        }
    }
}