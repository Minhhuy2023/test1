using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Foreach
    {
        public static void Foreachtest()
        {
            string[] cars = {"Volvo", "BMW", "Ford", "Mazda" };
            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }
            int[][] JaggedArray =
                            {
                                new int[] { 1, 2, 3 },
                                new int[] { 5, 2, 4, 1, 6},
                                new int[] { 7, 3, 4, 2, 1, 5, 9, 8}
                            };

            /*
             * Tương tự như dùng for, ta cũng dùng 2 vòng foreach lồng vào nhau để duyệt mảng.
             */
            foreach (int[] Element in JaggedArray)
            {
                foreach (int item in Element)
                {
                    Console.Write(item + "  ");
                }
                Console.WriteLine();
            }
        }
    }
}
