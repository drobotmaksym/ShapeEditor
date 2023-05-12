namespace ShapeEditor.Model;

public class FilledDiamond : Diamond
{
    public override void Render(Graphics graphics)
    {
        graphics.FillPolygon(Brushes.Black, points);
    }

    public override string ToString()
    {
        return "Зафарбований ромб: " + base.ToString();
    }
}
