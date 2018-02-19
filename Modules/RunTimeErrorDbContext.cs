using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Driver;

namespace Modules
{
      public class  RunTimeErrorDbContext:MongoClient
    {
        public RunTimeErrorDbContext():base("mongodb://97.64.122.225:27017"){ }
    }
}
