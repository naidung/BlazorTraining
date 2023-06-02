using ShopOnline.API.Entities;
using ShopOnline.Models.DTOs;
using System.Linq;

namespace ShopOnline.API.Extensions
{
    public static class DtoConversions
    {
        public static IEnumerable<ProductDto> ConvertToProductDto(this IEnumerable<Product> products, IEnumerable<ProductCategory> productCategories)
        {
            return (from product in products
                    join productCategory in productCategories
                    on product.CategoryID equals productCategory.ID
                    select new ProductDto
                    {
                        ID = product.ID,
                        Name = product.Name,
                        CategoryID = productCategory.ID,
                        CategoryName = productCategory.Name,
                        Desc = product.Desc,
                        ImageURL = product.ImageURL,
                        Price = product.Price,
                        Qty = product.Qty,
                    }).ToList();
        }

        public static ProductDto ConvertToProductDto(this Product product, ProductCategory productCategory)
        {
            return new ProductDto
            {
                ID = product.ID,
                Name = productCategory.Name,
                CategoryID = productCategory.ID,
                CategoryName = productCategory.Name,
                Desc = product.Desc,
                ImageURL = product.ImageURL,
                Price = product.Price
            };
        }

    }
}
