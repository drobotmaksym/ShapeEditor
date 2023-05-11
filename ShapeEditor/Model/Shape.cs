namespace ShapeEditor.Model;

public abstract class Shape
{
    public Point Location { get; } = new Point();

    public Shape()
    {
        Init();
    }

    public abstract void Init();

    public abstract void Move(int x, int y);

    public abstract void Shift(int dx, int dy);

    public abstract void Scale(double scale);

    public abstract double Area();

    public abstract double Perimeter();

    public abstract void Render(Graphics graphics);
}
