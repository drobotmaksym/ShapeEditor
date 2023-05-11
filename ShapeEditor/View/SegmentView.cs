using ShapeEditor.Model;

namespace ShapeEditor.View;

public class SegmentView : ShapeView
{
    public SegmentView() : base("Відрізок") { }

    public override Shape CreateShapeInstance()
    {
        return new Segment();
    }
}
