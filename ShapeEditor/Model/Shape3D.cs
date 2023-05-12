using System.Drawing;

namespace ShapeEditor.Model;

public abstract class Shape3D : Shape
{
    protected Point[,] points = new Point[0,0];

    public override void Move(int x, int y)
    {
        for (int i = 0; i < points.GetLength(0); i++)
        {
            for (int j = 0; j < points.GetLength(1); j++)
            {
                Point point = points[i, j];
                point.X = x;
                point.Y = y;
            }
        }
    }

    public override void Shift(int dx, int dy)
    {
        for (int i = 0; i < points.GetLength(0); i++)
            for (int j = 0; j < points.GetLength(1); j++)
                points[i, j].Offset(dx, dy);
    }

    public override void Scale(double scale)
    {
        double factor = scale / CurrentScale;

        for (int i = 0; i < points.GetLength(0); i++)
        {
            for (int j = 0; j < points.GetLength(1); j++)
            {
                Point point = points[i, j];
                point.X = (int)(point.X * factor);
                point.Y = (int)(point.Y * factor);
                points[i, j] = point;
            }
        }

        CurrentScale = scale;
    }

    public override void Render(Graphics graphics)
    {
        for (int i = 0; i < points.GetLength(0); i++)
        {
            var polygon = new Point[points.GetLength(1)];
            for (int j = 0; j < points.GetLength(1); j++)
                polygon[j] = points[i, j];

            graphics.DrawPolygon(Pens.Black, polygon);
        }   
    }
}
