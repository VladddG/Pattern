using System;
using System.Collections.Generic;
using System.Text;

namespace GameManager
{
    public class Context
    {
        Strategy _strategy;

        public Context(Strategy strategy)
        {
            this._strategy = strategy;
        }

        public void ContextInterface()
        {
            _strategy.SpawnCreeps();
        }
    }
}
