using SmartShop.Application1.Contracts;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartShop.Model.Model;
using SmartShop.Dtos.Dtos;

namespace SmartShop.Application1.Services
{
    public class CategoryServices : ICategoryServices
    {
        //private readonly IMapper _mapper;
        private  ICategoryRepository _categoryRepository;
        private IMapper _mapper;
      
        public CategoryServices(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }
        public List<CategoryDtos> GetAllPagination(int num, int category)
        {
            var Categories = _categoryRepository.GetAll().Skip(num*category).Take(category).ToList();
            var Allcategories=_mapper.Map<List<CategoryDtos>>(Categories);    
            return Allcategories;
        }

        public CategoryDtos GetCategory(int id)
        {
           var category =  _categoryRepository.GetById(id);
           var categoryDto= _mapper.Map<CategoryDtos>(category);
            return categoryDto;
        }
        public  CategoryDtos AddCategory(CategoryDtos category)
        {
             var AddCategory = _mapper.Map<Category>(category);
             var data=_categoryRepository.Add(AddCategory);
             _categoryRepository.Save();
             var categoryDto = _mapper.Map<CategoryDtos>(data);

            return categoryDto;
        }

        public CategoryDtos UpdateCategory(CategoryDtos category)
        {
            var UpdateCategory = _mapper.Map<Category>(category);
            var data = _categoryRepository.Update(UpdateCategory);
            _categoryRepository.Save();
            var categoryDto = _mapper.Map<CategoryDtos>(data);
            return categoryDto;

        }
        public void DeleteCategory(CategoryDtos category)
        {
            var DeleteCategory = _mapper.Map<Category>(category);
            _categoryRepository.Delete(DeleteCategory);
            _categoryRepository.Save();
        }

       

    }
}
