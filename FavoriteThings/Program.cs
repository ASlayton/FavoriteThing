using System;
using FavoriteThings.Things;

namespace FavoriteThings
{
    class Program
    {
        static void Main(string[] args)
        {
            var thing1 = new Item1();
            var thing2 = new Item2();
            var thing3 = new Item3();
            var thing4 = new Item4();

            var things = new ThingBase[] {thing1, thing2, thing3, thing4};
            foreach (var item in things)
            {
                item.GetItem();
            }

            Console.WriteLine("Press Enter To Exit.");
            Console.ReadLine();
        }
    }
}
