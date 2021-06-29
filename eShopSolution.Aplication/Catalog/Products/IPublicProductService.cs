using eShopSolution.Aplication.Catalog.Products.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Aplication.Catalog.Products
{
    public interface IPublicProductService
    {
        int Create(ProductEditRequest request);
        int Update(ProductEditRequest request);
        int Delete(int productId);
        List<ProductViewModal> GetAll();
        PageViewModel<ProductViewModal> GetAllPaging(string keyword, int pageIndex, int pageSize);
    }
}
