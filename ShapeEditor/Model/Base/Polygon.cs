namespace ShapeEditor.Model.Base;

public class Polygon
{
    private Point[] points;

    public Polygon(params Point[] points)
    {
        this.points = points;
    }

    public int NumberOfPoints => points.Length;
    public Point this[int index] => points[index];

    public void Offset(int dx, int dy)
    {
        for (int i = 0; i < NumberOfPoints; i++)
        {
            Point point = points[i];
            point.Offset(dx, dy);
            points[i] = point;
        }
    }

    public double GetPerimeter()
    {
        double perimeter = 0;

        for (int i = 1; i < points.Length; i++)
            perimeter += Utils.GetDistance(points[i], points[i - 1]);

        perimeter += Utils.GetDistance(points[0], points[NumberOfPoints - 1]);

        return perimeter;
    }

    public double GetArea()
    {
        return Math.Abs(
            points.Take(NumberOfPoints - 1)
                .Select((p, i) => (points[i + 1].X - p.X) * (points[i + 1].Y + p.Y))
                .Sum() / 2
        );
    }

    public Point[] GetPointsCopy()
    {
        var copy = new Point[NumberOfPoints];
        Array.Copy(points, copy, NumberOfPoints);
        return copy;
    }
}