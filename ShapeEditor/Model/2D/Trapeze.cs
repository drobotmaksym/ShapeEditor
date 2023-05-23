using ShapeEditor.Model.Base;

namespace ShapeEditor.Model._2D;

public class Trapeze : Shape2D
{
    private static readonly Polygon DefaultPolygon = new(
        new Point(-25, -25),
        new Point(25, -25),
        new Point(50, 25),
        new Point(-50, 25),
        new Point(-25, -25)
    );

    public Trapeze() : base(DefaultPolygon)
    {
    }
}