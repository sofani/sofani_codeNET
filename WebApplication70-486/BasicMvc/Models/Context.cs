using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicMvc.Models
{
    public class Context : DbContext
    {
        public DbSet<Session> Sessions { get; set; }

        public DbSet<Speaker> Speakers { get; set; }
    }
}
