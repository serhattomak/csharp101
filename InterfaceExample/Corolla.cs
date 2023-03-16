using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    internal class Corolla:IAutomobile
    {
        public int WheelNumber()
        {
            return 4;
        }

        public Brand BrandName()
        {
            return Brand.Toyota;
        }

        public Color StandartColor()
        {
            return Color.White;
        }
    }
}
