using K207AjaxApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace K207AjaxApp.Data
{
    public class AjaxContext:DbContext
    {
        public AjaxContext(DbContextOptions<AjaxContext>options)
            :base(options)
        {
        }
        public DbSet<Marka> Markas { get; set; }
        public DbSet<Model> Models { get; set; }
    }
}
