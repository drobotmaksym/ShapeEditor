using ShapeEditor.Model;

namespace ShapeEditor.View;

public class FilledDiamondView : ShapeView
{
    public FilledDiamondView() : base("Зафарбований ромб") { }

    public override Shape CreateShapeInstance()
    {
        return new FilledDiamond();
    }
}