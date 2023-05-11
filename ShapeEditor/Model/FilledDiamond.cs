namespace ShapeEditor.Model;

public class FilledDiamond : Diamond
{
    public override void Render(Graphics graphics)
    {
        graphics.FillPolygon(Brushes.Black, points);
    }
}
