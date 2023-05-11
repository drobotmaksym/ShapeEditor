namespace ShapeEditor.Model;

public class Parallelepiped : Shape3D
{ 
    public override double Area()
    {
        return 0;
    }

    public override void Init()
    {
        points = new Point[,]
        {
            {  // Top
                new Point(50, 50),
                new Point(150, 50),
                new Point(200, 150),
                new Point(100, 150)
            }, // Bottom
            {
                new Point(50, 100),
                new Point(150, 100),
                new Point(200, 200),
                new Point(100, 200)
            }, // Right
            {
                new Point(50, 50),
                new Point(50, 100),
                new Point(100, 200),
                new Point(100, 150)
            }, // Left
            {
                new Point(150, 50),
                new Point(150, 100),
                new Point(200, 200),
                new Point(200, 150)
            }
        };
    }

    public override double Perimeter()
    {
        return 0;
    }
}
