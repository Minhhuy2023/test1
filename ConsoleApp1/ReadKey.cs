using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ReadKey
    {
        public int ScanKey()
        {
            int x;
            bool test = false;
            do
            {
                string readData = Console.ReadLine();
                test = int.TryParse(readData, out x);
                if (test)
                    Console.WriteLine("Success");
                else
                    Console.WriteLine("Fail");
            }
            while (!test);
            return x;        
        }
    }
}
