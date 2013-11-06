using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace Research.Builder
{
    class Client
    {
        public static void Main(String[] args)
        {
            FoodManager foodManager = new FoodManager();
            Builder builder;
            Console.WriteLine("Please Enter Food No");
            string no = Console.ReadLine();
            string foodType = "1";
            builder = (Builder)Assembly.Load("Builder").CreateInstance(foodType);
            foodManager.Constrcut(builder);
        }
    }
}
