using ShapeEditor.Model;

namespace ShapeEditor.View;

public class SegmentView : ShapeView
{
    public SegmentView() : base("Відрізок", typeof(Segment)) { }

    public override Shape CreateShapeInstance()
    {
        return new Segment();
    }
}
