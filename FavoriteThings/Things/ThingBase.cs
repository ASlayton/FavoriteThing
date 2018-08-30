using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings.Things
{
    abstract class ThingBase
    {
        protected readonly string _whichItem;

        public string Item { get; protected set; }
        public string WhichItem { get; }

        public ThingBase(string whichItem)
        {
            _whichItem = whichItem;
        }

        //Every class that uses this base class 
        public virtual void GetItem()
        {
            Console.WriteLine($"What is your {_whichItem} favorite tv show?");
            Item = Console.ReadLine();
        }

        //Ensure that each class that uses this base class has a print item method
        public abstract void PrintItem();
    }
}
