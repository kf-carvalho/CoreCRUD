using Microsoft.EntityFrameworkCore;
using QuestDS2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuestDS2.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) 
            : base(options)
        {
            
        }
        public DbSet<Jogador> jogadors { get; set; }
        public DbSet<Placar> placars { get; set; }

    }
}
