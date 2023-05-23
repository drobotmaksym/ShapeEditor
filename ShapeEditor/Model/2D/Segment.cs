using ShapeEditor.Model.Base;

namespace ShapeEditor.Model._2D;

public class Segment : Shape2D
{
    private static readonly Polygon DefaultPolygon = new(
        new Point(-50, -50),
        new Point(50, 50)
    );

    public Segment() : base(DefaultPolygon)
    {
    }
}