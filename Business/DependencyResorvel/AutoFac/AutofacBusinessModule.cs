using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Business.Abstract;
using Business.Concretes;
using Castle.DynamicProxy;
using Core.Utilities.Security.Jwt;
using DataAcceses.EntityFramework;
using Autofac.Extras.DynamicProxy;
using Core.Utilities.Interceptors;
using DataAcceses.Abstract;

namespace Business.DependecyResorve.Ninject
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<EfEmployeeDal>().As<EfEmployeeDal>().SingleInstance();
            builder.RegisterType<EmployeeManager>().As<IEmployeeServices>().SingleInstance();

            builder.RegisterType<EfNewsDal>().As<EfNewsDal>().SingleInstance();
            builder.RegisterType<NewsManager>().As<INewsServices>().SingleInstance();

            builder.RegisterType<AnnounCementsDal>().As<AnnounCementsDal>().SingleInstance();
            builder.RegisterType<AnnouncementManager>().As<IAnnouncementsService>().SingleInstance();

            builder.RegisterType<ContactDal>().As<ContactDal>();
            builder.RegisterType<ContactManager>().As<IContactService>().SingleInstance();


            builder.RegisterType<UserDal>().As<UserDal>();
            builder.RegisterType<UserManager>().As<IUserService>();

            builder.RegisterType<AuthManager>().As<IAuthService>();


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
