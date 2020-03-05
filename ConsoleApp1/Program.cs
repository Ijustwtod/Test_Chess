using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.Unicode;
            char[,] sch = new char[8, 8];
            Pole cl = new Pole();
            bool x = true;
            cl.Zapolnenie(sch);
            while (x)
            {
                cl.Vivod(sch);
                cl.Contact(sch);
                Console.ReadKey();
            }
        }
    }
}
