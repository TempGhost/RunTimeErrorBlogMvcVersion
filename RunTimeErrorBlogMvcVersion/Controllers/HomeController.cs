﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters.Internal;
using Modules;
using MongoDB.Bson;
using MongoDB.Driver;
using Newtonsoft.Json;

namespace RunTimeErrorBlogMvcVersion.Controllers{
    public class HomeController : Controller{
        public IActionResult Index(){
            //new Task(() => {
            //    try{
                    
            //        using (var db =  RunTimeErrorDb.GetInstance()){
            //            db.Insert(new ViewLog{
            //                ip = "1"
            //            });
            //        }
            //    }
            //    catch (Exception ex){
            //    }
            //}).Start();
            return View();
        }

        public IActionResult About(){
            ViewData["Message"] = "Your application description page.";  
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

public IActionResult SnapShot(){
            return View();
        }
    }
}
