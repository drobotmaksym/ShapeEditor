using ShapeEditor.Model;

namespace ShapeEditor.View;

public class FilledDiamondView : ShapeView
{
    public FilledDiamondView() 
        : base("Зафарбований ромб", typeof(FilledDiamond)) { }

    public override Shape CreateShapeInstance()
    {
        return new FilledDiamond();
    }
}