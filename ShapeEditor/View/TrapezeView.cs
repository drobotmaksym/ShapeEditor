using ShapeEditor.Model;
using ShapeEditor.Model._2D;
using ShapeEditor.Model.Base;

namespace ShapeEditor.View;

public class TrapezeView : ShapeView
{
    public TrapezeView() : base("Трапеція", typeof(Trapeze))
    {
    }

    public override Shape CreateShapeInstance()
    {
        return new Trapeze();
    }
}