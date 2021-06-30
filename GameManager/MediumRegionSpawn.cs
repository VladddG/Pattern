using CreepGenerator;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameManager
{
    public class MediumRegionSpawn : Strategy
    {
        private int playerLevel;
        private HighCritter highCritter;
        private MediumCritter mediumCritter;

        public MediumRegionSpawn(CreepFactory factory, int playerLevel)
        {
            this.playerLevel = playerLevel;
            highCritter = factory.SpawnHigh();
            mediumCritter = factory.SpawnMedium();
        }

        public override void SpawnCreeps()
        {
            if(playerLevel == 10)
            {
                highCritter.rank = "yellow";
                mediumCritter.rank = "gray";
            }
        }
    }
}
