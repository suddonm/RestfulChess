using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestfulChess.Models
{
    public class Game
    {
        public long Id { get; set; }
        public string MoveList { get; set; }

        public Game()
        {

        }
    }
}
