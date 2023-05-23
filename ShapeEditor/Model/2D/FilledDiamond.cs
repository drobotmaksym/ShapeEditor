namespace ShapeEditor.Model._2D;

public class FilledDiamond : Diamond
{
    public override void Render(Graphics graphics)
    {
        graphics.FillPolygon(Brushes.Black, Polygon.GetPointsCopy());
    }
}