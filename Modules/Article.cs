using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Modules
{
     public  class Article{ 
        [BsonId]
        public ObjectId Id{ get; set; }
        //public string type { get; set; } 
        [BsonElement]
        public string ArticleTitle { get; set; }
        [BsonElement]
        public string ArticlContent { get; set; } 
        //public Nullable<System.DateTime> createdate { get; set; }
 
    }
}
