using ShapeEditor.Model;
using ShapeEditor.Model._3D;
using ShapeEditor.Model.Base;

namespace ShapeEditor.View;

public class ParallelepipedView : ShapeView
{
    public ParallelepipedView() :
        base("Паралелепіпед", typeof(Parallelepiped))
    {
    }

    public override Shape CreateShapeInstance()
    {
        return new Parallelepiped();
    }
}