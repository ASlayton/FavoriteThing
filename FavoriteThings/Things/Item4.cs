using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings.Things
{
    class Item4 : ThingBase
    {
        //Constructor for Item 4- pass in property of first to the item base
        public Item4() : base("fourth")
        { }

        //Print the name of the item in the console
        public override void PrintItem()
        {
            Console.WriteLine($"Your fourth favorite tv show is {Item}");
        }
    }
}
