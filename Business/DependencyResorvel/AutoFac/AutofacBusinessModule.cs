using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Business.Abstract;
using Business.Concretes;
using Castle.Core.Configuration;
using Castle.DynamicProxy;
using Core.Utilities.Security.Jwt;
using DataAcceses.EntityFramework;
using Autofac.Extras.DynamicProxy;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Interceptors;

namespace Business.DependecyResorve.Ninject
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<EfEmployeeDal>().As<EfEmployeeDal>().SingleInstance();
            builder.RegisterType<IEmployeeServices>().As<EmployeeManager>().SingleInstance();

            builder.RegisterType<INewsServices>().As<NewsManager>().SingleInstance();
            builder.RegisterType<EfNewsDal>().As<EfNewsDal>().SingleInstance();

            builder.RegisterType<AnnounCementsDal>().As<AnnounCementsDal>().SingleInstance();
            builder.RegisterType<IAnnouncementsService>().As<AnnouncementManager>().SingleInstance();

            builder.RegisterType<IContactService>().As<ContactManager>().SingleInstance();
            builder.RegisterType<ContactDal>().As<ContactDal>();

            builder.RegisterType<JwtHelper>().As<ITokenHelper>().SingleInstance();

            var assemly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assemly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectIncerteptorSelector()
                }).SingleInstance();
        }
    }
}
