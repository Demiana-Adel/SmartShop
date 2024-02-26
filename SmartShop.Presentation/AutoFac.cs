using Autofac;
using AutoMapper;
using SmartShop.Application1.Contracts;
using SmartShop.Application1.Mapper;
using SmartShop.Application1.Services;
using SmartShop.Context.Context;
using SmartShop.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartShop.Presentation
{
    public class AutoFac
    {
        public static IContainer Inject()
        {

            var builder = new ContainerBuilder();

            // Register your services and their dependencies
            builder.RegisterType<UserServices>().As<IUserServices>().InstancePerLifetimeScope();
            builder.RegisterType<UserRepository>().As<IUserRepository>();

            builder.RegisterType<CategoryServices>().As<ICategoryServices>().InstancePerLifetimeScope();
            builder.RegisterType<CategoryRepository>().As<ICategoryRepository>();

            builder.RegisterType<ProductServices>().As<IProductServices>().InstancePerLifetimeScope();
            builder.RegisterType<ProductRepository>().As<IProductRepository>();

            builder.RegisterType<OrderServices>().As<IOrderServices>().InstancePerLifetimeScope();
            builder.RegisterType<OrderRepository>().As<IOrderRepository>();
           
            builder.RegisterType<SmartShopDBContext>().As<SmartShopDBContext>();
            builder.Register(c => new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperProfile>();
            })).AsSelf().SingleInstance();

            builder.Register(c => c.Resolve<MapperConfiguration>().CreateMapper(c.Resolve))
                   .As<IMapper>()
                   .InstancePerLifetimeScope();


            // Build the container
            return builder.Build();




        }
    }
}
