namespace ShapeEditor.Model;

public class Diamond : Shape2D
{
    public override void Init()
    {
        points = new Point[]
        {
            new Point(50, 0),
            new Point(100, 50),
            new Point(50, 100),
            new Point(0, 50)
        };
    }

    public override double Area()
    {
        int dx1 = points[0].X - points[2].X;
        int dy1 = points[0].Y - points[2].Y;
        double d1 = Math.Sqrt(dx1 * dx1 + dy1 * dy1);

        int dx2 = points[1].X - points[3].X;
        int dy2 = points[1].Y - points[3].Y;
        double d2 = Math.Sqrt(dx2 * dx2 + dy2 * dy2);

        return d1 * d2 / 2;
    }

    public override double Perimeter()
    {
        return 0;
    }
}
