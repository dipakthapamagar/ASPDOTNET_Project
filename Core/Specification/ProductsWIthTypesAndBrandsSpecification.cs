using System;
using System.Linq.Expressions;
using Core.Entities;

namespace Core.Specification
{
    public class ProductsWIthTypesAndBrandsSpecification : BaseSpecification<Product>
    {
        public ProductsWIthTypesAndBrandsSpecification(ProductSpecParams productParams)
            : base(x =>
                (string.IsNullOrEmpty(productParams.Search) || x.Name.ToLower().Contains(productParams.Search))&&
                (!productParams.BrandID.HasValue || x.ProductBrandId ==  productParams.BrandID) &&
                (!productParams.TypeID.HasValue || x.ProductTypeId == productParams.TypeID)
            )
        {
            AddInclude(x => x.ProductType);
            AddInclude(x => x.ProductBrand);
            AddOrderBy(x => x.Name);
            ApplyPaging(productParams.PageSize *(productParams.PageIndex - 1), productParams.PageSize);

            if (!string.IsNullOrEmpty(productParams.Sort))
            {
                switch (productParams.Sort)
                {
                    case "priceAsc":
                        AddOrderBy(p => p.Price);
                        break;
                    case "priceDesc":
                        AddOrderByDescending(p => p.Price);
                        break;
                    default :
                        AddOrderBy(p => p.Name);
                        break;

                }
            }
        }

        public ProductsWIthTypesAndBrandsSpecification(int id) : base(x => x.Id==id)
        {
             AddInclude(x => x.ProductType);
            AddInclude(x => x.ProductBrand);
        }
    }
}