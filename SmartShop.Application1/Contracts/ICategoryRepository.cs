
using SmartShop.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartShop.Application1.Contracts
{
    public interface ICategoryRepository:IRepository<Category ,int>
    {
        public Category SearchByName(string name);
    }
}
