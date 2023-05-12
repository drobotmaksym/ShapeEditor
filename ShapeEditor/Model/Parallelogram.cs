namespace ShapeEditor.Model;

public class Parallelogram : Shape2D
{
    public override void Init()
    {
        points = new Point[] {
            new Point(0, 0),
            new Point(100, 0),
            new Point(150, 100),
            new Point(50, 100)
        };
    }

    public override double Area()
    {
        int a = points[1].X - points[0].X;
        int h = points[2].Y - points[0].Y;

        return a * h;
    }

    public override double Perimeter()
    {
        int a = points[1].X - points[0].X;

        int x = points[1].X - points[2].X;
        int y = points[1].Y - points[2].Y;

        double b = Math.Sqrt(x * x + y * y);

        return 2 * (a + b);
    }

    public override string ToString()
    {
        return "Паралелограм: " + base.ToString();
    }
}
