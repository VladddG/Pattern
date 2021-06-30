using CreepGenerator.ConcreteFactories;
using GameManager;
using System;

namespace SpawnManager
{
    public enum PlayerZone
    {
        BossZone,
        NormalZone
    }

    public enum MonsterRank
    {
        Gray,
        Yellow,
        Red
    }

    class Program
    {
        private static int PlayerLevel;
        private static PlayerZone currentPlayerZone;
        static void Main(string[] args)
        {
            PlayerLevel = 10;
            currentPlayerZone = PlayerZone.BossZone;

            if (PlayerLevel == 10)
            {
                if (currentPlayerZone == PlayerZone.BossZone)
                {
                    Context context = new Context(new HighRegionSpawn(new HighRegionFactory(), PlayerLevel));
                    context.ContextInterface();
                }
                else if (currentPlayerZone == PlayerZone.NormalZone)
                {
                    Context context = new Context(new MediumRegionSpawn(new MediumRegionFactory(), PlayerLevel));
                    context.ContextInterface();
                }
            }

            if (PlayerLevel == 50)
            {
                if (currentPlayerZone == PlayerZone.BossZone)
                {
                    Context context = new Context(new MediumRegionSpawn(new MediumRegionFactory(), PlayerLevel));
                    context.ContextInterface();
                }
                else if (currentPlayerZone == PlayerZone.NormalZone)
                {
                    Context context = new Context(new HighRegionSpawn(new HighRegionFactory(), PlayerLevel));
                    context.ContextInterface();
                }
            }
        }
    }
}
