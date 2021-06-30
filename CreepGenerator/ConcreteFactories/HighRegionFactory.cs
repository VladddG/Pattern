using CreepGenerator.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace CreepGenerator.ConcreteFactories
{
    public class HighRegionFactory : CreepFactory
    {
        public override HighCritter SpawnHigh()
            => new Songoku();


        public override MediumCritter SpawnMedium()
            => new Wolf();
    }
}
