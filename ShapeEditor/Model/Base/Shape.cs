namespace ShapeEditor.Model.Base;

public abstract class Shape
{
    private double scale = 1;

    public string Id => GetType().Name;

    public double Scale
    {
        get => scale;
        set
        {
            if (value <= 0) throw new ArgumentException("Scale must be more than zero.");
            scale = value;
        }
    }

    public Point Position { get; set; }

    public virtual void Move(int x, int y)
    {
        Position = new Point(x, y);
    }

    public virtual void Shift(int dx, int dy)
    {
        Move(Position.X + dx, Position.Y + dy);
    }

    public abstract double GetArea();

    public abstract double GetPerimeter();

    public abstract void Render(Graphics graphics);

    public override string ToString()
    {
        return $"{GetType().Name}: Location = {Position}, Scale = {Scale}";
    }
}