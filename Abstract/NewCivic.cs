using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    public class NewCivic:Automobile
    {
        public override Brand BrandName()
        {
            return Brand.Honda;
        }

        public override Color StandartColor()
        {
            return Color.Gray;
        }
    }
}
