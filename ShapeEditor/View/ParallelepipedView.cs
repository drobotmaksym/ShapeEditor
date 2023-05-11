using ShapeEditor.Model;

namespace ShapeEditor.View;

public class ParallelepipedView : ShapeView
{
    public ParallelepipedView() : base("Паралелепіпед") { }

    public override Shape CreateShapeInstance()
    {
        return new Parallelepiped();
    }
}