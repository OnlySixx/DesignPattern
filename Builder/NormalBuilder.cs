using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Research.Builder
{
    class NormalBuilder:Builder
    {
        private Food normalFood = new Food();

        public override void BuildHamb()
        {
            normalFood.Add("NormalHamb","$10.50");
        }
        public override void BuildCoke()
        {
            normalFood.Add("CokeCole","$4.50");
        }
        public override void BuildChip()
       {
           normalFood.Add("FireChips", "￥2.00");
        }

        public override Food GetFood()
        {
            return normalFood;
        }
    }
}
