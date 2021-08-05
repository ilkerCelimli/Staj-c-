using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Concretes;
using DataAcceses.EntityFramework;
using Ninject.Modules;

namespace Business.DependecyResorve.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<EfEmployeeDal>().To<EfEmployeeDal>().InSingletonScope();
            Bind<IEmployeeServices>().To<EmployeeManager>().InSingletonScope();

            Bind<INewsServices>().To<NewsManager>().InSingletonScope();
            Bind<EfNewsDal>().To<EfNewsDal>().InSingletonScope();

            Bind<AnnounCementsDal>().To<AnnounCementsDal>().InSingletonScope();
            Bind<IAnnouncementsService>().To<AnnouncementManager>().InSingletonScope();

            Bind<IContactService>().To<ContactManager>().InSingletonScope();
            Bind<ContactDal>().To<ContactDal>();
        }
    }
}
