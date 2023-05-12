namespace ShapeEditor.Model;

public class Parallelepiped : Shape3D
{ 
    public override void Init()
    {
        points = new Point[,]
        {
            {  // Top
                new Point(0, 0),
                new Point(100, 0),
                new Point(150, 100),
                new Point(50, 100)
            }, // Bottom
            {
                new Point(0, 50),
                new Point(100, 50),
                new Point(150, 150),
                new Point(50, 150)
            }, // Right
            {
                new Point(0, 0),
                new Point(0, 50),
                new Point(50, 150),
                new Point(50, 100)
            }, // Left
            {
                new Point(100, 50),
                new Point(100, 0),
                new Point(150, 100),
                new Point(150, 150)
            }
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

    public override string ToString()
    {
        return "Паралелепіпед: " + base.ToString();
    }
}
