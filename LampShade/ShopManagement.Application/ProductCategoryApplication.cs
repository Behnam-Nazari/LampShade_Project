using ShopManagement.Application.Contracts.ProductCategory;
using ShopManagement.Domain.ProductCategoryAgg;

namespace ShopManagement.Application
{
    public class ProductCategoryApplication: IProductCategoryApplication

    {
        private readonly IProductCategoryRepository _productCategoryRespository;

        public ProductCategoryApplication(IProductCategoryRepository productCategoryRespository)
        {
            _productCategoryRespository = productCategoryRespository;
        }

        public void Create(CreateProductCategory command)
        {
            throw new NotImplementedException();
        }

        public void Edit(EditProductCategory command)
        {
            throw new NotImplementedException();
        }

        public EditProductCategory GetDetails(long id)
        {
            throw new NotImplementedException();
        }
        
        public List<ProductCategoryViewModel> GetProductCategories()
        {
            throw new NotImplementedException();
        }

        public List<ProductCategoryViewModel> Search(ProductCategorySearchModel searchModel)
        {
            throw new NotImplementedException();
        }
    }
}