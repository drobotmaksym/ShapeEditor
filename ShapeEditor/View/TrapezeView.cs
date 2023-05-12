using ShapeEditor.Model;

namespace ShapeEditor.View;

public class TrapezeView : ShapeView
{
    public TrapezeView() : base("Трапеція", typeof(Trapeze)) { }

    public override Shape CreateShapeInstance()
    {
        return new Trapeze();
    }
}