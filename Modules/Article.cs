using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
namespace Modules
{
     public partial class Article{

        public int id{ get; set; }
        //public string type { get; set; }
 
        public string articletitle { get; set; }

        public string articlcontent { get; set; }

        //public Nullable<System.DateTime> createdate { get; set; }
 
    }
}
