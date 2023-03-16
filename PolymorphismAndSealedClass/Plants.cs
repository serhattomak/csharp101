using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAndSealedClass
{
    public class Plants : LivingBeing
    {
        protected void Photosynthesis()
        {
            Console.WriteLine("Plants do photosynthesis.");
        }

        public override void ResponseToStimuli()
        {
            //base.ResponseToStimuli();
            Console.WriteLine("Plants response to the Sun.");
        }
    }

    public class SeedBearingPlants : Plants
    {
        public SeedBearingPlants()
        {
            base.Photosynthesis();
            base.Nutrition();
            base.Breathe();
            base.Excrete();
            base.ResponseToStimuli();
        }
        public void SeedBearing()
        {
            Console.WriteLine("Seed-bearing plants reproduce by seeds.");
        }
    }

    public class SeedlessPlants : Plants
    {
        public SeedlessPlants()
        {
            base.Photosynthesis();
            base.Nutrition();
            base.Breathe();
            base.Excrete();
        }
        public void Spore()
        {
            Console.WriteLine("Seedless plants reproduce with spores.");
        }
    }
}
