using System.Text;
using System.Xml.Serialization;

namespace ShapeEditor.Model;

[Serializable]
public class Image
{
    private Point location = new(10, 10);
    private List<Shape> shapes = new();
    private XmlSerializer serializer;

    public Image()
    {
        // Smells bad
        Type[] types =
        {
            typeof(Diamond),
            typeof(FilledDiamond),
            typeof(Parallelepiped),
            typeof(Parallelogram),
            typeof(Segment),
            typeof(Trapeze)
        };

        serializer = new XmlSerializer(typeof(Image), types);
    }

    [XmlIgnore]
    public Shape? SelectedShape { get; set; } = null;
    public List<Shape> Shapes => shapes;

    public void AddShape(Shape shape)
    {
        shapes.Add(shape);
        Select(shape);
    }

    public void RemoveShape(Shape shape)
    {
        shapes.Remove(shape);
    }

    public void RemoveAllShapes()
    {
        shapes.Clear();
    }

    public void SelectNext()
    {
        if (SelectedShape == null)
        {
            Select(shapes.FirstOrDefault());
            return;
        }
  
        int nextIndex = shapes.IndexOf(SelectedShape) + 1;
            
        if (nextIndex < shapes.Count) 
            Select(shapes[nextIndex]);
        else
            Select(shapes.FirstOrDefault());
    }

    public void RemoveSelectedShape()
    {
        if (SelectedShape == null) return;
        Shape selected = SelectedShape;
        SelectNext();
        RemoveShape(selected);
    }

    public void Select(Shape? shape)
    {
        SelectedShape = shape;
    }

    public void Deselect()
    {
        SelectedShape = null;
    }

    public double TotalArea()
    {
        double area = 0;
        foreach (Shape shape in shapes) area += shape.Area();
        return area;
    }

    public double TotalPerimeter()
    {
        double perimeter = 0;
        foreach (Shape shape in shapes) perimeter += shape.Perimeter();
        return perimeter;
    }

    public void MoveShapes(int x, int y)
    {
        foreach (Shape shape in shapes) shape.Move(x, y);
    }

    public void MoveSelf(int x, int y)
    {
        location.X = x;
        location.Y = y;
    }

    public void Scale(double scale)
    {
        foreach (Shape shape in shapes) shape.Scale(scale);
    }

    public void Merge(Image image)
    {
        foreach (Shape shape in image.shapes) AddShape(shape);
    }

    public void Render(Graphics graphics)
    {
        foreach (Shape shape in shapes) shape.Render(graphics);
    }

    public void Save(string path)
    {
        try
        {
            using Stream stream = File.OpenWrite(path);
            serializer.Serialize(stream, this);
        }
        catch (Exception exception)
        {
            Utils.ShowErrorBox(
                "Помилка при збереженні зображення.\n" +
                "Причина помилки: " + exception.Message
                );
        }
    }

    public void Load(string path)
    {
        try
        {
            using Stream stream = File.OpenRead(path);
            Image? image = serializer.Deserialize(stream) as Image;
            if (image == null) throw new NullReferenceException();
            RemoveAllShapes();
            Merge(image);
        }
        catch (Exception exception)
        {
            Utils.ShowErrorBox(
                "Помилка при відкритті зображення.\n" +
                "Причина помилки: " + exception.Message
                );
        }
    }

    public override string ToString()
    {
        StringBuilder builder = new();
        foreach (Shape shape in shapes) builder.Append(shape + "\n");
        return builder.ToString();
    }
}