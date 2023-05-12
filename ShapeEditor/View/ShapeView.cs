using ShapeEditor.Model;

namespace ShapeEditor.View;

public abstract class ShapeView
{
    private string name;
    private Type type;

    public ShapeView(string name, Type type)
    {
        this.name = name;
        this.type = type;
    }

    public string Name => name;
    public Type Type => type;

    public abstract Shape CreateShapeInstance();
}
