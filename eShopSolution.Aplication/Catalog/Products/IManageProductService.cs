using eShopSolution.Aplication.Catalog.Products.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Aplication.Catalog.Products
{
    public interface IManageProductService
    {
        int Create(ProductEditRequest request);

    }
}
