using ShapeEditor.Model;
using ShapeEditor.Model._2D;
using ShapeEditor.Model.Base;

namespace ShapeEditor.View;

public class SegmentView : ShapeView
{
    public SegmentView() : base("Відрізок", typeof(Segment))
    {
    }

    public override Shape CreateShapeInstance()
    {
        return new Segment();
    }
}