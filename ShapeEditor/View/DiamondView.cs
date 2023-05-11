using ShapeEditor.Model;

namespace ShapeEditor.View;

public class DiamondView : ShapeView
{
    public DiamondView() : base("Ромб") { }

    public override Shape CreateShapeInstance()
    {
        return new Diamond();
    }
}