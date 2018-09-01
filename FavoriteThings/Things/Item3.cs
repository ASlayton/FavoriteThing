using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings.Things
{
    class Item3 : ThingBase
    {
        //Constructor for Item 3- pass in property of first to the item base
        public Item3() : base("third")
        { }

        public override void DoThings()
        {
            string newPhrase = "";
            foreach (var letter in Item)
            {
                newPhrase += letter + "-";
            }
        }

        //Print the name of the item in the console
        public override void PrintItem()
        {
            Console.WriteLine($"Your third favorite tv show is {Item}");
        }
    }
}
