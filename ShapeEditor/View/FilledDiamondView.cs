using ShapeEditor.Model;
using ShapeEditor.Model._2D;
using ShapeEditor.Model.Base;

namespace ShapeEditor.View;

public class FilledDiamondView : ShapeView
{
    public FilledDiamondView()
        : base("Зафарбований ромб", typeof(FilledDiamond))
    {
    }

    public override Shape CreateShapeInstance()
    {
        return new FilledDiamond();
    }
}