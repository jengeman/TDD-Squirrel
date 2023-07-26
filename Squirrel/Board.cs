using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakesAndLadders
{
    public class Board
    {
        private int _endposition;

        public Board(int boardsize) 
        {
            _endposition = boardsize*boardsize-1;
        }

        public int getEndposition()
        {
            return _endposition;
        }

    }
}
