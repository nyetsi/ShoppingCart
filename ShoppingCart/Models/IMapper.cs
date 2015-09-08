using Shopping.Data.DataModels;

namespace MvcApplication1.Models
{
    public interface IMapper
    {
        Product Map(ProductViewModel model);
    }
}