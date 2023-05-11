namespace ShapeEditor.Model;

public class Parallelogram : Shape2D
{
    public override void Init()
    {
        points = new Point[] {
            new Point(50, 0),
            new Point(150, 0),
            new Point(200, 100),
            new Point(100, 100)
        };
    }

    public override double Area()
    {
        return 0;
    }

    public override double Perimeter()
    {
        return 0;
    }
}
