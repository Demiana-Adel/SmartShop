
using SmartShop.Dtos.Dtos;
using SmartShop.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartShop.Application1.Contracts
{
    public interface IProductRepository:IRepository<Product , int>
    {
        IQueryable<Product> SerchByName(string name); 
    }
}
