using ShapeEditor.DataAccess;
using ShapeEditor.Model.Base;

namespace ShapeEditor.Model;

[Serializable]
public class Image
{
    private ImageRepository imageRepository = new();
    private List<Shape> shapes = new();

    public List<Shape> Shapes => shapes;
    public string Id => Guid.NewGuid().ToString();
    public Point Location { get; private set; }
    
    // Required for serialization
    public List<Shape> ListOfShapes
    {
        get => new(shapes);
        set => shapes = value;
    }
    
    public void AddShape(Shape shape)
    {
        shapes.Add(shape);
    }

    public void RemoveShape(Shape shape)
    {
        shapes.Remove(shape);
    }

    public void RemoveAllShapes()
    {
        shapes.Clear();
    }

    public double TotalArea()
    {
        return shapes.Select(shape => shape.GetArea()).Sum();
    }

    public double TotalPerimeter()
    {
        return shapes.Select(shape => shape.GetPerimeter()).Sum();
    }

    public void MoveShapes(int x, int y)
    {
        foreach (Shape shape in shapes) shape.Move(x, y);
    }

    public void MoveSelf(int x, int y)
    {
        Location = new Point(x, y);
    }

    public void Scale(double scale)
    {
        foreach (Shape shape in shapes) shape.Scale = scale;
    }

    public void Merge(Image image)
    {
        foreach (Shape shape in image.shapes) AddShape(shape);
    }

    public void Render(Graphics graphics)
    {
        foreach (Shape shape in shapes) shape.Render(graphics);
    }

    public void Save()
    {
        try
        {
            if (imageRepository.ContainsEntity(this))
                imageRepository.UpdateEntity(this);
            else
                imageRepository.CreateEntity(this);
        }
        catch (DataAccessException)
        {
            Utils.ShowErrorBox("Помилка при збереженні зображення.");
        }
    }

    public void Load(string id)
    {
        try
        {
            Merge(imageRepository.GetEntityById(id));
        }
        catch (DataAccessException)
        {
            Utils.ShowErrorBox("Помилка при відкритті зображення.");
        }
    }
}