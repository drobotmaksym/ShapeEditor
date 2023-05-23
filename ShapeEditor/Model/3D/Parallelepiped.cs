using ShapeEditor.Model.Base;

namespace ShapeEditor.Model._3D;

public class Parallelepiped : Shape3D
{
    private static readonly Polygon[] DefaultPolygons =
    {
        // Top
        new(
            new Point(0, 50),
            new Point(50, 50),
            new Point(0, -50),
            new Point(-50, 50),
            new Point(0, 50)
        ),

        // Bottom
        new(
            new Point(0, 0),
            new Point(50, 75),
            new Point(0, 75),
            new Point(-50, 0),
            new Point(0, 0)
        ),

        // Left
        new(
            new Point(-50, 50),
            new Point(0, -50),
            new Point(0, 75),
            new Point(-50, 0),
            new Point(-50, 50)
        ),

        // Right
        new(
            new Point(0, 50),
            new Point(50, 50),
            new Point(50, 75),
            new Point(0, 0),
            new Point(0, 50)
        ),

        // Front
        new(
            new Point(0, -50),
            new Point(50, 50),
            new Point(50, 75),
            new Point(0, 75),
            new Point(0, -50)
        ),

        // Back
        new(
            new Point(-50, 50),
            new Point(0, 50),
            new Point(0, 0),
            new Point(-50, 0),
            new Point(-50, 50)
        )
    };

    public Parallelepiped() : base(DefaultPolygons)
    {
    }
}