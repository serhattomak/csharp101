using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    public class Focus : IAutomobile
    {
        public int WheelNumber()
        {
            return 4;
        }

        public Brand BrandName()
        {
            return Brand.Ford;
        }

        public Color StandartColor()
        {
            return Color.White;
        }
    }
}
