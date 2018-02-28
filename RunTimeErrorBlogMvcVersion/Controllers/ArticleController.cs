using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using Modules;
using MongoDB.Bson;
using MongoDB.Driver;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RunTimeErrorBlogMvcVersion.Controllers{
    public class ArticleController : Controller{
        // GET: /<controller>/
        public IActionResult AddArticle(){
            return View();
        }

        [HttpGet]
        public JsonResult GetArticle(){ 
            var server = new MongoClient("mongodb://97.64.122.225:27017");
            server.StartSession();
            var db = (server.GetDatabase("RunTimeError"));  
            var atrcles = db.GetCollection<Article>("Article");
            var result =  atrcles.Find(x => 1 == 1).ToList();
            return Json("111");
            //using(var db = RunTimeErrorDb.GetInstance()){ 6
            //    var article = db.Queryable<Article>().Where( x=> 1==1).ToList();
            //    return Json(article);
            //} 
        }


        [HttpPost]
        public void AddArticle(Article article){
            //     using (var db = RunTimeErrorDb.GetInstance())
            //     { 
            // db.Insert(article); 
            //}  
            var server = new MongoClient("mongodb://97.64.122.225:27017");
            server.StartSession();
            var db = server.GetDatabase("RunTimeError");
            var collection = db.GetCollection<Article>("Article");
            collection.InsertOne(article);
            Response.Redirect("../Home/RunTimeLOG");
        }
    }
}