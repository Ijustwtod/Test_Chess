using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Figuri
    {
        public char[,] Peshka(char[,] sch, int x, int y, int x1, int y1)
        {
            if(sch[x,y] == 'p' && (x1 - x) == 1 && y1 == y)
            {
                sch[x1, y1] = 'p';
                sch[x, y] = ' ';
            }
            else if (sch[x,y] == 'P' && (x-x1) == 1 && y1 == y)
            { 
                sch[x1, y1] = 'P';
                sch[x, y] = ' ';
            }
            return sch;
        }
    }
}
