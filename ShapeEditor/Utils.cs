namespace ShapeEditor;

public static class Utils
{
    public static string GetDirectoryPath(string directory)
    {
        return Path.Combine(Configuration.ApplicationRoot, directory);
    }

    public static void ShowErrorBox(string error)
    {
        MessageBox.Show(
            error,
            @"Помилка",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error
        );
    }

    public static void ShowInfoBox(string info)
    {
        MessageBox.Show(
            info,
            @"Повідомлення",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
        );
    }

    public static double GetDistance(Point pointA, Point pointB)
    {
        int dx = pointA.X - pointB.X;
        int dy = pointA.Y - pointB.Y;

        return Math.Sqrt(dx * dx + dy * dy);
    }
}