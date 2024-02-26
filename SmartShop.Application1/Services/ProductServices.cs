using AutoMapper;
using SmartShop.Application1.Contracts;
using SmartShop.Dtos.Dtos;
using SmartShop.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartShop.Application1.Services
{
    public class ProductServices : IProductServices
    {
        private IProductRepository _productRepository;
        private IMapper _mapper;
        public ProductServices(IProductRepository productRepository , IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }
        public List<ProductDtos> GetAllPagination(int num, int product)
        {
            var products= _productRepository.GetAll().Skip(num * product).Take(product).ToList();
            var AllProducts=_mapper.Map<List<ProductDtos>>(products);
            return AllProducts;
        }

        public ProductDtos GetProduct(int id)
        {
            var product= _productRepository.GetById(id);
            var productDto=_mapper.Map<ProductDtos>(product);
            return productDto;
        }
        public ProductDtos AddProduct(ProductDtos product)
        {
            var AddProduct =_mapper.Map<Product>(product);
            var data = _productRepository.Add(AddProduct);
            _productRepository.Save();
            var productDto = _mapper.Map<ProductDtos>(data);
            return productDto;
        }
        public ProductDtos UpdateProduct(ProductDtos product)
        {
            var UpdateProduct=_mapper.Map<Product>(product);    
            var data = _productRepository.Update(UpdateProduct);
            _productRepository.Save();
            var productDto = _mapper.Map<ProductDtos>(data);
            return productDto;
        }

        public void DeleteProduct(ProductDtos product)
        {
            var DeleteProduct=_mapper.Map<Product>(product);
            _productRepository.Delete(DeleteProduct);
            _productRepository.Save();
        }

        public List<ProductDtos> SearchByName(string partName)
        {

            var data = _productRepository.SerchByName(partName);
            var productDtos = _mapper.Map<List<ProductDtos>>(data);
            return productDtos;
        }

    }
    
}
