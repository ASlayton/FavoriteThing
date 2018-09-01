using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings.Things
{
    class Item2 : ThingBase
    {
        //Constructor for Item 2- pass in property of first to the item base
        public Item2() : base("second")
        { }

        public override void DoThings()
        {
            Item.ToString().ToLower();
        }

        //Print the name of the item in the console
        public override void PrintItem()
        {
            Console.WriteLine($"Your second favorite tv show is {Item}");
        }
    }
}
