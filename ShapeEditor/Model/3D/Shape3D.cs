using ShapeEditor.Model.Base;

namespace ShapeEditor.Model._3D;

[Serializable]
public abstract class Shape3D : Shape
{
    private Polygon[] polygons;

    public Shape3D(Polygon[] polygons)
    {
        this.polygons = polygons;
    }

    public new void Shift(int dx, int dy)
    {
        base.Shift(dx, dy);
        foreach (Polygon polygon in polygons)
            polygon.Offset(dx, dy);
    }

    public override void Render(Graphics graphics)
    {
        foreach (Polygon polygon in polygons)
            graphics.DrawPolygon(
                Pens.Black,
                polygon.GetPointsCopy()
            );
    }

    public override double GetPerimeter()
    {
        return polygons.Select(polygon => polygon.GetPerimeter()).Sum();
    }

    public override double GetArea()
    {
        return polygons.Select(polygon => polygon.GetArea()).Sum();
    }
}