using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Result;
using DataAcceses.EntityFramework;
using Entities.Concretes;

namespace Business.Abstract
{
public interface INewsServices
{

    IResult AddNews(News news);
    IResult DeleteNews(int id);
    IResult UpdateNews(int id ,News news);
    IResult GetAllNews();
    IResult GetNews(int id);

}
}
