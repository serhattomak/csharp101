﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    public class NewFocus:Automobile
    {
        public override Brand BrandName()
        {
            return Brand.Ford;
        }
    }
}
