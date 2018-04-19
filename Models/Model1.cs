using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2API.Models
{
    public class Model1 : DbContext
    {
        public Model1()
        {
        }

        // constructor

        public Model1(DbContextOptions<Model1>options) : base(options)
        {


        }

        public DbSet<Table1> Table1 { get; set; }
    }
}
