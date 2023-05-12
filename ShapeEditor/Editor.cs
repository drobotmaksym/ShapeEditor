using ShapeEditor.Model;
using ShapeEditor.View;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using Image = ShapeEditor.Model.Image;

namespace ShapeEditor;

public partial class Editor : Form
{
    private BindingList<ShapeView> shapeList = new();
    private Image image = new();

    public Editor()
    {
        InitializeComponent();

        List<ShapeView> views = new()
        {
            new SegmentView(),
            new DiamondView(),
            new FilledDiamondView(),
            new TrapezeView(),
            new ParallelogramView(),
            new ParallelepipedView()
        };

        foreach (ShapeView view in views) shapeList.Add(view);
    }

    private void Editor_Load(object sender, EventArgs e)
    {
        shapeBox.DisplayMember = "Name";
        shapeBox.DataSource = shapeList;
    }

    private void picture_Paint(object sender, PaintEventArgs e)
    {
        Graphics graphics = e.Graphics;
        graphics.Clear(Color.White);
        image.Render(graphics);
    }

    private void UpdateInfo()
    {
        Shape? selected = image.SelectedShape;
        if (selected == null) return;
        xCoord.Value = selected.Location.X;
        yCoord.Value = selected.Location.Y;
        scale.Value = (int)selected.CurrentScale;
        info.Text = selected.ToString();
    }

    private void add_Click(object sender, EventArgs e)
    {
        if (shapeBox.SelectedIndex == -1) return;
        ShapeView selected = shapeList[shapeBox.SelectedIndex];
        image.AddShape(selected.CreateShapeInstance());
        UpdateInfo();
        picture.Refresh();
    }

    private void remove_Click(object sender, EventArgs e)
    {
        image.RemoveSelectedShape();
        picture.Refresh();
    }

    private void clear_Click(object sender, EventArgs e)
    {
        image.RemoveAllShapes();
        picture.Refresh();
    }

    private void next_Click(object sender, EventArgs e)
    {
        image.SelectNext();
        UpdateInfo();
    }

    private void save_Click(object sender, EventArgs e)
    {
        DialogResult result = saveDialog.ShowDialog();
        if (result == DialogResult.OK)
            image.Save(saveDialog.FileName);
    }

    private void open_Click(object sender, EventArgs e)
    {
        DialogResult result = fileDialog.ShowDialog();
        if (result != DialogResult.OK) return;
        image.Load(fileDialog.FileName);
        picture.Refresh();
    }

    private void author_Click(object sender, EventArgs e)
    {
        Utils.ShowInfoBox(
            """
            Дробот Максим Євгенович - король андалів та перших людей.
            Його волосся блискуче як золото, а очі світяться 
            як діаманти. 
            """
            );
    }

    private void xCoord_ValueChanged(object sender, EventArgs e)
    {
        if (image.SelectedShape == null) return;
        if (!int.TryParse(xCoord.Value.ToString(), out int x))
            throw new ArgumentException();

        image.SelectedShape.Move(
            x,
            image.SelectedShape.Location.Y
            );

        UpdateInfo();
        picture.Refresh();
    }

    private void yCoord_ValueChanged(object sender, EventArgs e)
    {
        if (image.SelectedShape == null) return;
        if (!int.TryParse(yCoord.Value.ToString(), out int y))
            throw new ArgumentException();

        image.SelectedShape.Move(
            image.SelectedShape.Location.X,
            y
            );

        UpdateInfo();
        picture.Refresh();
    }

    private void scale_ValueChanged(object sender, EventArgs e)
    {
        Shape? selected = image.SelectedShape;
        if (selected == null) return;

        bool parsed = double.TryParse(
            scale.Value.ToString(),
            out double value
            );

        if (parsed == false) throw new ArgumentException();
        selected.Scale(value);
        UpdateInfo();
        picture.Refresh();
    }
}