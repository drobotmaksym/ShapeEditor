namespace ShapeEditor.Model;

public static class Configuration
{
    public static readonly string ShapeDirectory;

    static Configuration()
    {
        string appdata = Environment.GetFolderPath(
            Environment.SpecialFolder.ApplicationData
            );

        ShapeDirectory = Path.Combine(appdata, "ShapeEditor");
    }
}
