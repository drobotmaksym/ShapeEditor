namespace ShapeEditor.Model;

public class Segment : Shape2D
{
    public override void Init()
    {
        points = new Point[]
        {
            new Point(),
            new Point(100, 100)
        };
    }

    public override double Area()
    {
        return 0;
    }

    public override double Perimeter()
    {
        int dx = points[1].X - points[0].X;
        int dy = points[1].Y - points[0].Y;
        return Math.Sqrt(dx * dx + dy * dy);
    }

    public override string? ToString()
    {
        return $"Segment";
    }
}
