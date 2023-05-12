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
        Location = new Point(Location.X + dx, Location.Y + dy);
        for (int i = 0; i < points.Length; i++)
            points[i].Offset(dx, dy);
    }

    public override void Scale(double scale)
    {
        double factor = scale / CurrentScale;

        for (int i = 0; i < points.Length; i++)
        {
            points[i].X = (int)(points[i].X * factor);
            points[i].Y = (int)(points[i].Y * factor);
        }

        CurrentScale = scale;
    }

    public override void Render(Graphics graphics)
    {
        graphics.DrawPolygon(Pens.Black, points);
    }
}
