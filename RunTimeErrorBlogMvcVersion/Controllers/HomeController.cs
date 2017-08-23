using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters.Internal;
using Modules;
using MySqlSugar;
using Newtonsoft.Json;

namespace RunTimeErrorBlogMvcVersion.Controllers{
    public class HomeController : Controller{
        public IActionResult Index(){
            new Task(() => {
                try{
                    
                    using (var db =  RunTimeErrorDb.GetInstance()){
                        db.Insert(new ViewLog{
                            ip = "1"
                        });
                    }
                }
                catch (Exception ex){
                }
            }).Start();
            return View();
        }

        public IActionResult About(){
            ViewData["Message"] = "Your application description page.";
            var flag = false;

            return View();
        }

        public IActionResult Contact(){
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error(){
            return View();
        }

        public IActionResult RunTimeLOG(){ 
            return View();
        } 

        public JsonResult GetArticle() {  
        using(var db = RunTimeErrorDb.GetInstance()){
            var article = db.Queryable<Article>().Where( x=> 1==1).ToList();
            return Json(article);
        } 
    } 

public IActionResult SnapShot(){
            return View();
        }
    }
}
