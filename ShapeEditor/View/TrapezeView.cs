using ShapeEditor.Model;

namespace ShapeEditor.View;

public class TrapezeView : ShapeView
{
    public TrapezeView() : base("Трапеція") { }

    public override Shape CreateShapeInstance()
    {
        return new Trapeze();
    }
}