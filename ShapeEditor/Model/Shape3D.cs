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
        for (int i = 0; i < points.GetLength(0); i++)
        {
            for (int j = 0; j < points.GetLength(1); j++)
            {
                Point point = points[i, j];
                point.X = (int)(point.X * scale);
                point.Y = (int)(point.Y * scale);
            }
        }
    }

    public override void Render(Graphics graphics)
    {
        for (int i = 0; i < points.GetLength(0); i++)
        {
            var polygons = new Point[points.GetLength(1)];
            for (int j = 0; j < points.GetLength(1); j++)
                polygons[j] = points[i, j];

            graphics.DrawPolygon(Pens.Black, polygons);
        }   
    }
}
