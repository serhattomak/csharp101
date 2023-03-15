using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Animals:LivingBeing
    {
        protected void Adaption()
        {
            Console.WriteLine("Animals can adapt.");
        }
    }

    public class Reptiles:Animals
    {
        public Reptiles()
        {
            base.Adaption();
            base.Nutrition();
            base.Breathe();
            base.Excrete();
        }
        public void Crawling()
        {
            Console.WriteLine("Reptiles move by crawling.");
        }
    }

    public class Birds:Animals
    {
        public Birds()
        {
            base.Adaption();
            base.Nutrition();
            base.Breathe();
            base.Excrete();
        }
        public void Flying()
        {
            Console.WriteLine("Birds can fly.");
        }
    }
}
