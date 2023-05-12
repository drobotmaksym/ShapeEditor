using ShapeEditor.View;
using System.Collections.Generic;
using System.Reflection;

namespace ShapeEditor.Model;

public static class Utils
{
    public static void ShowErrorBox(string error)
    {
        MessageBox.Show(
            error,
            "Помилка",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error
            );
    }

    public static void ShowInfoBox(string info)
    {
        MessageBox.Show(
            info,
            "Повідомлення",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
            );
    }

    public static List<ShapeView> FetchShapeViews()
    {
        return new()
        {
            new SegmentView(),
            new DiamondView(),
            new FilledDiamondView(),
            new TrapezeView(),
            new ParallelogramView(),
            new ParallelepipedView()
        };
    }

    public static IEnumerable<Type> FetchShapeTypes
        (List<ShapeView> views)
    {
        foreach (ShapeView view in views) yield return view.Type;
    }
}
