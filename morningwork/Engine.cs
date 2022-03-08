using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace morningwork
{
    public enum EngineType
    {
        Gas,
        Electric,
        Hybrid,
        Diesel,
    }
    public class Engine
    {
        public int _engineType;
        public int _cylinders;

        public Engine(int engineType, int cylinders)
        {
            _engineType = engineType;
            _cylinders = cylinders;
        }
    }
}
