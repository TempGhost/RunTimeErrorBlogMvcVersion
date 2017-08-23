using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using Modules;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RunTimeErrorBlogMvcVersion.Controllers
{
    public class ArticleController : Controller
    {
        // GET: /<controller>/
        public IActionResult AddArticle()
        {
            return View();
        }

        [HttpPost]
        public void AddArticle(Article article){
            using (var db = RunTimeErrorDb.GetInstance())
            { 
        db.Insert(article);
       }
             Response.Redirect("../Home/RunTimeLOG");
       } 
    }
}
