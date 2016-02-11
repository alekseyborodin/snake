using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = 1;
            int y1 = 3;
            char sum1 = '*';

            drow(x1, y1, sum1);

            int x2 = 2;
            int y2 = 5;
            char sum1 = '#';

            drow(x2, y2, sum2);

            Console.ReadKey();

       
        }

        static void drow (int x,int y,char sum)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sum);
        }
    }
}
