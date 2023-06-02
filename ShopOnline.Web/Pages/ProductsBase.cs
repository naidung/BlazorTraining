using Microsoft.AspNetCore.Components;
using ShopOnline.Models.DTOs;
using ShopOnline.Web.Services.Contracts;

namespace ShopOnline.Web.Pages
{
    public class ProductsBase : ComponentBase
    {
        [Inject]
        public IProductService? productService { get; set; }
        public IEnumerable<ProductDto>? products { get; set; }

        protected override async Task OnInitializedAsync()
        {
            if (productService != null)
                products = await productService.GetItems();
        }

        protected IOrderedEnumerable<IGrouping<int, ProductDto>> GroupedByCategory()
        {
            return from product in products
                   group product by product.CategoryID into groupedCategory
                   orderby groupedCategory.Key
                   select groupedCategory;
        }

        protected string GetCategoryNameOfGroupedProds(IGrouping<int, ProductDto> group)
        {
            var firstProd = group.FirstOrDefault(p => p.CategoryID == group.Key);
            return firstProd?.CategoryName ?? "";
        }

    }
}
