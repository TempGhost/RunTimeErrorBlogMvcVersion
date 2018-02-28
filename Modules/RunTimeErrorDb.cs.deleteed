using System;
using Microsoft.EntityFrameworkCore;
using MySqlSugar;
using MySQL.Data.EntityFrameworkCore.Extensions;

namespace Modules{
    public class RunTimeErrorDb{

        private RunTimeErrorDb(){

        }

        public static string ConnectionString{
            get{

                string reval =
                    "server=45.78.61.164;port=3306;uid=dbadmin;pwd=nimadepo;database=runtimeerrordb;SslMode=none";
                return reval;
            }
        }

        public static SqlSugarClient GetInstance(){
            var db = new SqlSugarClient(ConnectionString);
            db.IsEnableLogEvent = true; //Enable log events
            db.LogEventStarting = (sql, par) => { Console.WriteLine(sql + " " + par + "\r\n"); };
            return db;
        }


        //public virtual   <Article> Article { get; set; }

        //public virtual DbSet<ViewLog> ViewLog{ get; set; }

    }

    public class RunTimeErrorEfDb : DbContext{
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=45.78.61.164;port=3306;uid=dbadmin;pwd=nimadepo;database=runtimeerrordb;SslMode=none");
        }
        public virtual DbSet<Article> Article { get; set; }
         public virtual DbSet<ViewLog> ViewLog { get; set; }

}

}
