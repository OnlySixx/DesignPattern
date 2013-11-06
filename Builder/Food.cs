using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Research.Builder
{
    class Food
    {
        Hashtable food = new Hashtable();
        public void Add(string name, string price)
        {
            food.Add(name,price);
        }
        public void Show()
        {
            IDictionaryEnumerator myEnumerator = food.GetEnumerator();
            Console.WriteLine("Food List");
            Console.WriteLine("---------------");
            string foodList = "";
            while (myEnumerator.MoveNext())
            {
                foodList = foodList + myEnumerator.Key.ToString();
                foodList = foodList + myEnumerator.Value.ToString();
            }
            Console.WriteLine(foodList);
            Console.WriteLine("\n------------------------------");
        }
    }
}
