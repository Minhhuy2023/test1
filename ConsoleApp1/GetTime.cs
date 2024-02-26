using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class GetTime
    {
        public string GetTimeNow()
        {
            int startTimeHH01 = int.Parse(DateTime.Now.ToString("HH"));
            int startTimemm01 = int.Parse(DateTime.Now.ToString("mm"));
            int startTimess01 = int.Parse(DateTime.Now.ToString("ss"));
            string time01 = string.Concat(startTimeHH01, ":" , startTimemm01, ":" , startTimess01);
            return time01;
        }
    }
}
