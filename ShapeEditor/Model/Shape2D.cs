namespace ShapeEditor.Model;

public abstract class Shape2D : Shape
{
    protected Point[] points = new Point[0];
    public int NumberOfPoints => points.Length;

    public Point this[int index]
    {
        get => points[index];
    }

    public override void Move(int x, int y)
    {
        Shift(x - Location.X, y - Location.Y);
    }

    public override void Shift(int dx, int dy)
    {
        foreach (Point point in points) point.Offset(dx, dy);
    }

    public override void Scale(double scale)
    {
        for (int i = 0; i < points.Length; i++)
        {
            points[i].X = (int)(points[i].X * scale);
            points[i].Y = (int)(points[i].Y * scale);
        }
    }

    public override void Render(Graphics graphics)
    {
        graphics.DrawPolygon(Pens.Black, points);
    }
}
