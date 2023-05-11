using ShapeEditor.Model;

namespace ShapeEditor.View;

public class ParallelogramView : ShapeView
{
    public ParallelogramView() : base("Паралелограм") { }

    public override Shape CreateShapeInstance()
    {
        return new Parallelogram();
    }
}