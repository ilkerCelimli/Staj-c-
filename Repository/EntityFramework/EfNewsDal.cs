using Core.Entities.Abstract;
using DataAcceses.Abstract;
using Entities.Concretes;
namespace DataAcceses.EntityFramework
{
    public class EfNewsDal : EfdbContextBase<News, DbContext>, IEntity,INewsDal
    {
        

    }
}
