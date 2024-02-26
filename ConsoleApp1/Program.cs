using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConsoleApp1;

namespace freetuts
{
    class freetuts
    {
        public static void Main(string[] args)
        {
            
            string abc = GetTimeNow();
            Console.WriteLine(abc);
            int[] ArrList = { 213, 231,302 };
            foreach (int item in ArrList)
            {
                Console.WriteLine(item);
            }
            Foreach.Foreachtest();
            ArayStudent.InArray1d();
            ArayStudent.OutArray1d();
            ArayStudent.InArray2d();
            ArayStudent.OutArray2d();
            ReadKey scanKeyTest = new ReadKey();
            int lengthY, lengthX;
            Console.WriteLine("Enter X: ");        // input X axis length..
            lengthX = scanKeyTest.ScanKey();      //input X axis length..
            Console.WriteLine("Enter Y: ");      //input Y axis length..
            lengthY = scanKeyTest.ScanKey();    //input Y axis length..
            Xprint xprint = new Xprint(); 
            xprint.X_print(lengthX,lengthY, '$', '.');
            RecPrint.RecPrt(lengthX, lengthY, '*', '.');
            TriangularPrint.triangular(lengthX, lengthY, '*', '.');
            RhombusPrint.rhombus(lengthX, lengthY, '*', '.');
            Console.ReadKey();
        }

        public static string GetTimeNow()
        {
            int startTimeHH01 = int.Parse(DateTime.Now.ToString("HH"));
            int startTimemm01 = int.Parse(DateTime.Now.ToString("mm"));
            int startTimess01 = int.Parse(DateTime.Now.ToString("ss"));
            string time01 = string.Concat("Now: ",startTimeHH01,":", startTimemm01,":",startTimess01);
            return time01;
        }
    }    
}