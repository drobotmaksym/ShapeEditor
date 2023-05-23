namespace ShapeEditor;

public class Configuration
{
    public static readonly string ApplicationRoot;

    static Configuration()
    {
        ApplicationRoot = Environment.GetFolderPath(
            Environment.SpecialFolder.ApplicationData
        );
    }
}