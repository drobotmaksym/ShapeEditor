namespace ShapeEditor.Model;

public class Trapeze : Shape2D
{
    public override void Init()
    {
        points = new Point[] {
            new Point(50, 0),
            new Point(150, 0),
            new Point(200, 100),
            new Point(0, 100)
        };
    }

    public override double Area()
    {
        int a = points[1].X - points[0].X;
        int b = points[2].X - points[3].X;
        int h = points[2].Y - points[0].Y;       

        return a * b * h / 2.0;
    }

    public override double Perimeter()
    {
        int a = points[1].X - points[0].X;
        int b = points[2].X - points[3].X;

        int x1 = points[0].X - points[3].X;
        int y1 = points[0].Y - points[3].Y;

        int x2 = points[1].X - points[2].X;
        int y2 = points[1].Y - points[2].Y;

        double c1 = Math.Sqrt(x1 * x1 + y1 * y1);
        double c2 = Math.Sqrt(x2 * x2 + y2 * y2);

        return a + b + c1 + c2;
    }

    public override string ToString()
    {
        return "Трапеція: " + base.ToString();
    }
}
