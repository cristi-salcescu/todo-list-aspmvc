using Core.Dtos;
using Front.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Front.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var indexModel = new IndexModel()
            {
                Todos = new List<TodoDto>()
                {
                    new TodoDto() { Id=1, Title = "todo1" },
                    new TodoDto() { Id=2, Title = "todo2" },
                    new TodoDto() { Id=3, Title = "todo3" }
                }
            };

            return View(indexModel);
        }
    }
}