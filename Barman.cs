using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock_project
{
    class Barman : IObserver
    {
        public void Update(int time)
        {
            switch (time)
            {
                case 16: Console.WriteLine("Barman brew beer!"); break;
                case 17: Console.WriteLine("Barman open the bar!"); break;
                case 23: Console.WriteLine("Barmen closethe bar!"); break;
            }
        }
    }
}
