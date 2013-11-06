using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Research.Builder
{
    class FoodManager
    {
        public void Constrcut(Builder builder)
        {
            builder.BuildChip();
            builder.BuildHamb();
            builder.BuildCoke();
        }
    }
}
