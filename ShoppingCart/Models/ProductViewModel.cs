using Shopping.Data.DataModels;

namespace MvcApplication1.Models
{
    public class ProductViewModel
    {
        public int ProductId { get; set; }
        public string Name { get; set; }



        public void MapToDataModel(Product product)
        {
            product.Name = Name;
        }
    }
}