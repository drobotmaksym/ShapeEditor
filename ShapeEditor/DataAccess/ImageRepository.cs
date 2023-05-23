using ShapeEditor.Model;
using ShapeEditor.Model.Base;
using Image = ShapeEditor.Model.Image;

namespace ShapeEditor.DataAccess;

public class ImageRepository : Repository<Image, string>
{
    public ImageRepository() : base("shapes")
    {
    }

    public override string GetEntityId(Image image)
    {
        return image.Id;
    }
}