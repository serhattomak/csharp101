using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    public abstract class Automobile
    {
        public int WheelNumber()
        {
            return 4;
        }

        public virtual Color StandartColor()
        {
            return Color.White;
        }

        public abstract Brand BrandName();
    }
}
