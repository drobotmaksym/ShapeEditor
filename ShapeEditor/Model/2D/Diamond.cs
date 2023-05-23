using ShapeEditor.Model.Base;

namespace ShapeEditor.Model._2D;

public class Diamond : Shape2D
{
    private static readonly Polygon DefaultPolygon = new(
        new Point(0, 25),
        new Point(12, 0),
        new Point(0, -25),
        new Point(-12, 0),
        new Point(0, 25)
        );

    public Diamond() : base(DefaultPolygon)
    {
    }
}