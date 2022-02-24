using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WcfServiceEmployee.Entity;

namespace WcfServiceEmployee.Data
{
    public class MyDBContext : DbContext
    {
        public MyDBContext():base ("name=WCFEmployee")
        {

        }
        public DbSet<Employee> Employees { get; set; }
    }
}