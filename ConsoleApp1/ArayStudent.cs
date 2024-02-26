using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ArayStudent
    {
         static string[] Array1d = new string[3];
        static string[ ,] Array2d = new string[3, 3];
        public static void InArray1d()
        {            
            Console.WriteLine(" Input Student Name : \n");
            for (int i = 0; i < Array1d.GetLength(0); i++)
            {
                Console.WriteLine("Student{0}: ", i);
                Array1d[i] = Console.ReadLine();
            }
        }
        public static void OutArray1d()
        {
            for (int j = 0; j < Array1d.GetLength(0); j++)
                Console.WriteLine(" Student{0}:   {1}",j, Array1d[j]); 
        }
        // 2D Array Funtion
        public static void InArray2d()
        {
            Console.WriteLine("please input 2D array:\n");
            for (int i = 0; i < Array2d.GetLength(0); i++)
            {
                for (int j = 0; j < Array2d.GetLength(1); j++)
                {
                    Console.Write("Array Axis[{0}:{1}]:  ", i, j);
                    Array2d[i,j] = Console.ReadLine();
                }
            }
        }
        public static   void OutArray2d()
        {
            Console.WriteLine("2D array print:\n");
            for (int i = 0; i < Array2d.GetLength(0); i++)
            {
                for (int j = 0; j < Array2d.GetLength(1); j++)
                {
                    Console.Write("Axis[{0}:{1}]  {2}   ", i, j, Array2d[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}
