using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Business.DependecyResorve.Ninject;
using Core.Result;
using Core.Result.Concrete;
using DataAcceses.Abstract;
using DataAcceses.EntityFramework;
using Entities.Concretes;

namespace Business.Concretes
{
   public class AnnouncementManager : IAnnouncementsService
   {
       private readonly AnnounCementsDal announCementsDal;

       public AnnouncementManager(AnnounCementsDal announCementsDal)
       {
           this.announCementsDal = announCementsDal;
       }



       public IResult AddAnnouncement(Announcements announcements)
       {
           try
           {
              announCementsDal.Add(announcements);
              return new SuccesfulResult("Eklendi");
           }
            catch (Exception e)
           {
               Console.Write(e.Message);
               return new ErrorResult(false, "Hata");

            }
        }

       public IResult DeleteAnnouncement(int id)
       {
           try
           {
               announCementsDal.Delete(announCementsDal.Get(i=> i .Id == id));

               return new SuccesfulResult("Eklendi");
           }
            catch (Exception e)
           {
               Console.Write(e.Message);
                return new ErrorResult(false, "Hata");

            }
        }

       public IResult UpdateAnnouncement(int id ,Announcements announcements)
       {
           try
           {
               Announcements dumy = announCementsDal.Get(a => a.Id == id);

               announcements.Id = dumy.Id;

               announCementsDal.Update(announcements);
               return new SuccesfulResult("Eklendi");
           }
            catch (Exception e)
           {
               Console.Write(e.Message);
                return new ErrorResult(false, "Hata");

            }
        }

       public IResult GetAllAnnouncement()
       {
           try
           {
               return new DataResult<Announcements>(announCementsDal.GetAll().ToList());
           }
           catch (Exception e)
           {
               Console.Write(e.Message);
                return new ErrorResult(false, "Hata");

            }
        }

       public IResult GetAnnouncement(int id)
       {
           try
           {
               return new SuccesfulResultData<Announcements>(announCementsDal.Get(i => i.Id == id));
           }
           catch (Exception e)
           {
               Console.Write(e.Message);
                return new ErrorResult(false, "Hata");

            }
        }
   }
}
