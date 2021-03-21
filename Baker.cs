using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock_project
{
    class Baker : IObserver
    {
        public void Update(int time)
        {
            switch (time)
            {
                case 4: Console.WriteLine("Baker fire oven!"); break;
                case 5: Console.WriteLine("Baker knead the dough!"); break;
                case 6: Console.WriteLine("Baker bake the dough!"); break;
                case 7: Console.WriteLine("Baker get the bake!"); break;
                case 8: Console.WriteLine("Baker open the bakery!"); break;
                case 16: Console.WriteLine("Baker closethe bakery!"); break;
            }
        }
    }
}
