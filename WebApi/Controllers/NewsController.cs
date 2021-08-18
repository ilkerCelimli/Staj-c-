using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Business.DependecyResorve.Ninject;
using Core.Result;
using Entities.Concretes;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class NewsController : Controller
    {

        private readonly INewsServices _services;

        public NewsController(INewsServices news)
        {
            _services = news;
        }

        [HttpGet("/News/getall")]

        public IResult GetAll()
        {
            return _services.GetAllNews();
        }

        [HttpGet("/News/getById")]

        public IResult GetById(int id)
        {
            return _services.GetNews(id);
        }

        [HttpPost("/News/AddNews")]

        public IResult AddNews(News news)
        {
            return _services.AddNews(news);
        }

        [HttpPut("/News/updateNews")]
        public IResult UpdateNews(int id, News news)
        {
            return _services.UpdateNews(id,news );

        }

        [HttpDelete("/News/deleteNews")]
        public IResult DeleteNews(int id)
        {

            return _services.DeleteNews(id);
        }

    }
}
