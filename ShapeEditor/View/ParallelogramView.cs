using ShapeEditor.Model;
using ShapeEditor.Model._2D;
using ShapeEditor.Model.Base;

namespace ShapeEditor.View;

public class ParallelogramView : ShapeView
{
    public ParallelogramView() :
        base("Паралелограм", typeof(Parallelogram))
    {
    }

    public override Shape CreateShapeInstance()
    {
        return new Parallelogram();
    }
}