using ShapeEditor.Model.Base;

namespace ShapeEditor.Model._2D;

[Serializable]
public abstract class Shape2D : Shape
{
    public Shape2D(Polygon polygon)
    {
        Polygon = polygon;
    }

    public Polygon Polygon { get; }

    public new void Shift(int dx, int dy)
    {
        base.Shift(dx, dy);
        Polygon.Offset(dx, dy);
    }

    public override double GetPerimeter()
    {
        return Polygon.GetPerimeter();
    }

    public override double GetArea()
    {
        return Polygon.GetArea();
    }

    public override void Render(Graphics graphics)
    {
        graphics.DrawPolygon(Pens.Black, Polygon.GetPointsCopy());
    }
}