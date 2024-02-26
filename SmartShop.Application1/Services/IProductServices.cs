
using SmartShop.Dtos.Dtos;
using SmartShop.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartShop.Application1.Services
{
    public interface IProductServices
    {
        List<ProductDtos> GetAllPagination(int num, int product);
        ProductDtos GetProduct(int id);
        ProductDtos AddProduct(ProductDtos product);
        ProductDtos UpdateProduct(ProductDtos product);
        void DeleteProduct(ProductDtos product);
        List<ProductDtos> SearchByName(string name);     


    }
}
