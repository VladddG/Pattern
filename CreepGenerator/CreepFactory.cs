using System;
using System.Collections.Generic;
using System.Text;

namespace CreepGenerator
{
    public abstract class CreepFactory
    {
        public abstract MediumCritter SpawnMedium();
        public abstract HighCritter SpawnHigh();
    }
}
