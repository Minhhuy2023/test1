using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public  class RecPrint
    {

        public static void RecPrt(int lengthX, int lengthY, char star, char insidechar)
        {
            for (int x = 0; x < lengthX; x++)
            {
                for (int y = 0; y < lengthY; y++)
                { 
                    if ((x == 0 || x == (lengthX - 1)) || (y == 0 || y == (lengthY - 1)))
                        Console.Write(star);
                    else
                        Console.Write(insidechar);
                }
                Console.WriteLine();
            }
        }        
    }
}
