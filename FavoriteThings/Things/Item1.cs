using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings.Things
{
    class Item1 : ThingBase
    {
        //Constructor for Item 1- pass in property of first to the item base
        public Item1() : base("first")
        { }

        public override void DoThings()
        {
            var changedLine1 = Item.ToString().ToUpper();
            Console.WriteLine($"{changedLine1}");
        }

        //Print the name of the item in the console
        public override void PrintItem()
        {
            Console.WriteLine($"Your first favorite tv show is {Item}");
        }
    }
}
