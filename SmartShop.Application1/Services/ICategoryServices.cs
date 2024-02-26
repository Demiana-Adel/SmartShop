
using SmartShop.Dtos.Dtos;
using SmartShop.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartShop.Application1.Services
{
    public interface ICategoryServices
    {
        List<CategoryDtos> GetAllPagination(int num, int category);
        CategoryDtos GetCategory(int id);
        CategoryDtos AddCategory(CategoryDtos category);
        CategoryDtos UpdateCategory(CategoryDtos category);
        void DeleteCategory(CategoryDtos category);
    }
}
