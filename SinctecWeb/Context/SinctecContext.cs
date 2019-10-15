using SinctecWeb.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SinctecWeb.Context
{
    public class SinctecContext : DbContext
    {
        public DbSet<Contact>Contact { get; set; }

        
    }
}