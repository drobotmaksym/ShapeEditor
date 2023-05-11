using System;
using System.Data;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json;
using System.Xml.Serialization;

namespace ShapeEditor.Model;

public class Image
{
    private Point location = new();
    private List<Shape> shapes = new();
    private Shape? selectedShape = null;

    public void AddShape(Shape shape) 
    {
        shapes.Add(shape);
    }

    public void RemoveShape(Shape shape) 
    {
        shapes.Remove(shape);
    }

    public void RemoveSelectedShape()
    {
        if (selectedShape == null) return;
        RemoveShape(selectedShape);
    }

    public void Select(Shape shape)
    {
        selectedShape = shape;
    }

    public double TotalArea() 
    {
        double area = 0;
        foreach (Shape shape in shapes) 
            area += shape.Area();
        return area; 
    }

    public double TotalPerimeter() 
    {
        double perimeter = 0;
        foreach (Shape shape in shapes) 
            perimeter += shape.Perimeter();
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
