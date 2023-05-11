using ShapeEditor.Model;
using ShapeEditor.View;
using System.ComponentModel;
using Image = ShapeEditor.Model.Image;

namespace ShapeEditor;

public partial class Editor : Form
{
    private BindingList<ShapeView> shapeList = new();
    private Image image = new();

    public Editor()
    {
        InitializeComponent();
    }

    private void add_Click(object sender, EventArgs e)
    {
        if (shapeBox.SelectedIndex == -1) return;
        ShapeView selected = shapeList[shapeBox.SelectedIndex];
        image.AddShape(selected.CreateShapeInstance());
        picture.Refresh();
    }

    private void Editor_Load(object sender, EventArgs e)
    {
        List<ShapeView> list = new()
        {
            new SegmentView(),
            new DiamondView(),
            new FilledDiamondView(),
            new TrapezeView(),
            new ParallelogramView(),
            new ParallelepipedView()
        };

        foreach (ShapeView view in list) shapeList.Add(view);

        shapeBox.DisplayMember = "Name";
        shapeBox.DataSource = shapeList;
    }

    private void picture_Paint(object sender, PaintEventArgs e)
    {
        Graphics graphics = e.Graphics;
        graphics.Clear(Color.White);
        image.Render(graphics);
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
        if (result == DialogResult.OK)
            image.Load(fileDialog.FileName);
    }

    private void author_Click(object sender, EventArgs e)
    {
        Utils.ShowInfoBox(
            "Його неперевершеність - Дробот Максим Євгенович."
            );
    }
}