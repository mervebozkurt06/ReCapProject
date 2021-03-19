using Autofac;
using Autofac.Extras.DynamicProxy;
using Bussiness.Abstract;
using Bussiness.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussiness.DependecyResolvers.Autofac
{
    public class AutofacBusinessModule : Module 
    {
        //over + space

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CarManager>().As<ICarService>().SingleInstance(); //IProductService istendiğinde ProductManager instance ı ver
            builder.RegisterType<EfCarDal>().As<ICarDal>().SingleInstance();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();

        }
    }
}
