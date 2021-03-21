using System;

namespace Clock_project
{
    class Shoemaker : IObserver
    {
        public void Update(int time)
        {
            switch(time)
            {
                case 10: Console.WriteLine("Shoemaker has opened!"); break;
                case 11: Console.WriteLine("Shoemaker is drinking beer!"); break;
                case 15: Console.WriteLine("Shoemaker is singing the song!"); break;
                case 18: Console.WriteLine("Shoemaker closed!"); break;
            }
        }
    }
}
