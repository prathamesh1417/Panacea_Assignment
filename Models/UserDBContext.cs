using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Panacea_Assignment.Models
{
    public class UserDBContext:DbContext
    {
        public DbSet<User_List> Users { get; set; }
      
    }
}