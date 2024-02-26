using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class RhombusPrint
    {
        public static void rhombus(int lengthX,int lengthY,char star, char insidechar)
        {
            int a1 = lengthX % 2;
            int b1 = lengthY % 2;
            for (int x=0;x < lengthX; x++)
            {
                for(int y = 0;y < lengthY; y++)
                {
                    if ((a1 == 1)&&(b1==1))
                    {
                        if ((y == (lengthY / 2) + x) || (y == (lengthY / 2) - x) || (x == (lengthX / 2) + y) || ((x == (lengthX/2+(lengthX -y-1))) && ((y == (lengthY/2+(lengthY-x-1))))))
                            Console.Write(star);
                        else
                            Console.Write(insidechar);
                    }                   
                    else
                     Console.WriteLine(insidechar);                       
                }
                Console.WriteLine();
            }
            Console.ReadKey();
            return;
        }
       
    }
}
