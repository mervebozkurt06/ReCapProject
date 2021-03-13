using Autofac;
using Bussiness.Abstract;
using Bussiness.Concrete;
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
        }
    }
}
