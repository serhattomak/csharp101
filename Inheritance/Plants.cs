using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Plants:LivingBeing
    {
        protected void Photosynthesis()
        {
            Console.WriteLine("Plants do photosynthesis.");
        }
    }

    public class SeedBearingPlants:Plants
    {
        public SeedBearingPlants()
        {
            base.Photosynthesis();
            base.Nutrition();
            base.Breathe();
            base.Excrete();
        }
        public void SeedBearing()
        {
            Console.WriteLine("Seed-bearing plants reproduce by seeds.");
        }
    }

    public class SeedlessPlants:Plants
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
