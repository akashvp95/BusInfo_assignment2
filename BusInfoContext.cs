using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.SqlClient;

namespace BusInfo_Assignment2.Models
{
    public class BusInfoContext : DbContext
    {
        public BusInfoContext()
            : base("name=BIDB")
        {

        }
        public DbSet<BusInfo> BusInfo { get; set; }
    }
}