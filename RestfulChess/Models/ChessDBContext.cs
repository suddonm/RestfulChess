using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RestfulChess.Models
{
    public class ChessDBContext : DbContext
    {
        public ChessDBContext(DbContextOptions<ChessDBContext> options)
            : base(options)
        {

        }

        public DbSet<Game> Games { get; set; }
    }
}
