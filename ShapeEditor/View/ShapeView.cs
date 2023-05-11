using ShapeEditor.Model;

namespace ShapeEditor.View;

public abstract class ShapeView
{
    private string name;

    public ShapeView(string name)
    {
        this.name = name;
    }

    public string Name => name;

    public abstract Shape CreateShapeInstance();
}
