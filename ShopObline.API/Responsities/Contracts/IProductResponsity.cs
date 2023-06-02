using ShopOnline.API.Entities;

namespace ShopOnline.API.Responsities.Contracts
{
    public interface IProductResponsity
    {
        Task<IEnumerable<Product>> GetItems();
        Task<IEnumerable<ProductCategory>> GetCategories();
        Task<Product> GetItem(int ID);
        Task<ProductCategory> GetCategory(int ID);
    }
}
