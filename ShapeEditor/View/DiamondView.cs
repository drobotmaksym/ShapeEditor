using ShapeEditor.Model;

namespace ShapeEditor.View;

public class DiamondView : ShapeView
{
    public DiamondView() : base("Ромб", typeof(Diamond)) { }

    public override Shape CreateShapeInstance()
    {
        return new Diamond();
    }
}