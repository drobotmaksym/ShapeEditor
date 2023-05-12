using ShapeEditor.Model;

namespace ShapeEditor.View;

public class ParallelogramView : ShapeView
{
    public ParallelogramView() : 
        base("Паралелограм", typeof(Parallelogram)) { }

    public override Shape CreateShapeInstance()
    {
        return new Parallelogram();
    }
}