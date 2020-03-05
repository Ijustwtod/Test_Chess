using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Pole
    {
        public char[,] Zapolnenie(char[,] sch)
        {
            char[] P1 = { 'r', 'n', 'b', 'q', 'k', 'b', 'n', 'r' };
            char[] P2 = { 'R', 'N', 'B', 'Q', 'K', 'B', 'N', 'R' };

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (i == 0)
                    {
                        sch[i, j] = P1[j];
                    }
                    else if(i == 1)
                    {
                        sch[i, j] = 'p';
                    }
                    else if(i == 6)
                    {
                        sch[i, j] = 'P';
                    }
                    else if (i == 7)
                    {
                        sch[i, j] = P2[j];
                    }
                    else
                    {
                        sch[i, j] = ' ';
                    }
                }
            }
            return sch;
        }
        public void Vivod(char[,] sch)
        {
            char[] A = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };
            Console.Write(" ");
            for (int i = 0; i < 8; i++)
            {
                Console.Write(" " + A[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < 8; i++)
            {
                Console.Write((8 - i) + " ");
                Console.Write("");
                for (int j = 0; j<8; j++)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    if ((i + j) % 2 == 0)
                    {
                        Console.BackgroundColor = ConsoleColor.Magenta;
                        Console.Write(sch[i, j] + " ");
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.Write(sch[i, j] + " ");
                    }
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        public char[,] Contact(char[,] sch)
        {
            Pole Pl = new Pole();
            bool d = true;
            int x = 0, y = 0, x1 = 0, y1 = 0;
            char buf = 'r';
            while (d)
            {
                switch(Console.ReadKey(true).Key)
                {
                    case ConsoleKey.UpArrow:
                        if (x != 0)
                        {
                            sch[x, y] = buf;
                            x1 = x;
                            y1 = y; 
                            x--;
                            buf = sch[x, y];
                            sch[x, y] = '⃞';
                            Console.Clear();
                            Pl.Vivod(sch);
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if (x != 7)
                        {
                            sch[x, y] = buf;
                            x1 = x;
                            y1 = y;
                            x++;
                            buf = sch[x, y];
                            sch[x, y] = '⃞';
                            Console.Clear();
                            Pl.Vivod(sch);
                        }
                        break;
                    case ConsoleKey.LeftArrow:
                        if (y != 0)
                        {
                            sch[x, y] = buf;
                            x1 = x;
                            y1 = y;
                            y--;
                            buf = sch[x, y];
                            sch[x, y] = '⃞';
                            Console.Clear();
                            Pl.Vivod(sch);
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        if (y != 7)
                        {
                            sch[x, y] = buf;
                            x1 = x;
                            y1 = y;
                            y++;
                            buf = sch[x, y];
                            sch[x, y] = '⃞';
                            Console.Clear();
                            Pl.Vivod(sch);
                        }
                        break;
                    case ConsoleKey.Enter:
         
                        d = false;
                        break;
                    default:
                        Console.WriteLine("Неверная клавиша попробуйте ещё раз!");
                        break;
                }
            }
            Figuri Fg = new Figuri();   
            Fg.Peshka(sch, x, y, x1, y1);
            return sch;
        }
    }
}
