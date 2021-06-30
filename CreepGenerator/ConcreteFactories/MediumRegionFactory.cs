using CreepGenerator.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace CreepGenerator.ConcreteFactories
{
    public class MediumRegionFactory : CreepFactory
    {
        public override HighCritter SpawnHigh()
        {
            return new NightElf();
        }

        public override MediumCritter SpawnMedium()
        {
            return new Cow();
        }
    }
}
