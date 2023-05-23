using ShapeEditor.Model;
using ShapeEditor.Model._2D;
using ShapeEditor.Model.Base;

namespace ShapeEditor.View;

public class DiamondView : ShapeView
{
    public DiamondView() : base("Ромб", typeof(Diamond))
    {
    }

    public override Shape CreateShapeInstance()
    {
        return new Diamond();
    }
}