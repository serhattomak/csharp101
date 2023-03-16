using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAndSealedClass
{
    public class LivingBeing
    {
        protected void Nutrition()
        {
            Console.WriteLine("All living being are fed.");
        }

        protected void Breathe()
        {
            Console.WriteLine("All living things breathe.");
        }

        protected void Excrete()
        {
            Console.WriteLine("All living beings excrete.");
        }

        public virtual void ResponseToStimuli()
        {
            Console.WriteLine("Living things response to stimuli.");
        }
    }
}
