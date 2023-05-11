namespace ShapeEditor.Model;

public static class Utils
{
    public static string GenerateShapePath()
    {
        return Path.Combine(
            Configuration.ShapeDirectory,
            Guid.NewGuid().ToString()
            );
    }

    public static void ShowErrorBox(string error)
    {
        MessageBox.Show(
            error,
            "Помилка",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error
            );
    }

    public static void ShowInfoBox(string info)
    {
        MessageBox.Show(
            info,
            "Повідомлення",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
            );
    }
}
