using Microsoft.EntityFrameworkCore;
using ShopOnline.API.Data;
using ShopOnline.API.Entities;
using ShopOnline.API.Responsities.Contracts;

namespace ShopOnline.API.Responsities
{
    public class ProductResponsity : IProductResponsity
    {
        private readonly ShopOnlineDBContext shopOnlineDBContext;

        public ProductResponsity(ShopOnlineDBContext shopOnlineDBContext)
        {
            this.shopOnlineDBContext = shopOnlineDBContext;
        }

        public async Task<IEnumerable<ProductCategory>> GetCategories()
        {
            var categories = await this.shopOnlineDBContext.ProductCategories.ToListAsync();
            return categories;
        }

        public async Task<ProductCategory> GetCategory(int ID)
        {
            var category = await this.shopOnlineDBContext.ProductCategories.FirstOrDefaultAsync(c => c.ID == ID);
            return category;
        }

        public async Task<Product> GetItem(int ID)
        {
           var product = await this.shopOnlineDBContext.Products.FirstOrDefaultAsync(c => c.ID == ID);
            return product;
        }

        public async Task<IEnumerable<Product>> GetItems()
        {
            var products = await shopOnlineDBContext.Products.ToListAsync();
            return products;
        }
    }
}
