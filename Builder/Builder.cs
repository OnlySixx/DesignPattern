using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Research.Builder
{
    public abstract class Builder
    {
        public abstract void BuildHamb();
        public abstract void BuildCoke();
        public abstract void BuildChip();
        public abstract Food GetFood();
    }
}
