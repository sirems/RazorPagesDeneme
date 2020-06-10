using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RazorPagesDeneme.Models
{
    public class OkulContext:DbContext
    {
        public OkulContext(DbContextOptions<OkulContext> options) : base(options)
        {

        }

        public DbSet<Kisi> Kisiler { get; set; }
    }
}
