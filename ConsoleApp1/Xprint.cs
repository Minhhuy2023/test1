using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Xprint
    {
        //char star = '*';
        //char insideChar = '.';
        //int lengthY, lengthX; 

        public void X_print(int lengthX, int lengthY, char star, char insideChar)
        {
            for (int x = 0; x<lengthX; x++)
                  {
                  for (int y = 0; y<lengthY; y++)
                  {                
                        if ((x==y)||((lengthX-x)==(y+1))) // 
                        Console.Write(star);
                        else
                        Console.Write(insideChar);
                  }
                Console.WriteLine();            
            }
        }
        
    }
}
