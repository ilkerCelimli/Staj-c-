using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Core.Result;
using Core.Result.Concrete;
using DataAcceses.EntityFramework;
using Entities.Concretes;

namespace Business.Concretes
{
   public class NewsManager : INewsServices
   {

       private EfNewsDal efNews;

       public NewsManager(EfNewsDal efNews)
       {
           this.efNews = efNews;
       } 

        public IResult AddNews(News news)
        {

            try
            {
                efNews.Add(news);
                return new SuccesfulResult(true, "Haber başarı ile kaydedildi.");
            }
            catch (Exception e)
            {
                return new ErrorResult(false, "Hata oluştu." );
            }

        }

        public IResult DeleteNews(int id)
        {
            try
            {
              News news = efNews.Get(n => n.Id == id);
                efNews.Delete(news);

                return new SuccesfulResult(true, "Haber silindi");
            }
            catch (Exception e)
            {
                return new ErrorResult(false, "Hata alındı");
                
            }
        }

        public IResult UpdateNews(News news)
        {
            try
            {
                efNews.Update(news);

                return new SuccesfulResult(true, "Güncellendi");
            }
            catch (Exception e)
            {
                return new ErrorResult(false, "Hata");
                
            }
        }

        public IResult GetAllNews()
        {
            try
            {
                return new DataResult<News>(efNews.GetAll().ToList());
            }
            catch (Exception e)
            {
                return new ErrorResult(false, "hata");
                
            }
        }

        public IResult GetNews(int id)
        {
            try
            {
                return new DataResult<News>(efNews.Get(n => n.Id ==id));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return new ErrorResult(false, "Hata");
            }
        }
    }
}
