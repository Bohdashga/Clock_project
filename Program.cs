using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock_project
{
    class Program
    {
        static void Main(string[] args)
        {
            Clock clock = Clock.GetInstance();

            for(int i=0;i<100;i++)
            {
                clock.NextHour();
            }

            Console.ReadKey();
        }
    }
}
