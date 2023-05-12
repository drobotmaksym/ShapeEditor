using ShapeEditor.Model;

namespace ShapeEditor.View;

public class ParallelepipedView : ShapeView
{
    public ParallelepipedView() : 
        base("Паралелепіпед", typeof(Parallelepiped)) { }

    public override Shape CreateShapeInstance()
    {
        return new Parallelepiped();
    }
}