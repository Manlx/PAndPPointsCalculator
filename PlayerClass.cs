using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAndPPointsCalculator
{
    class Player
    {
        public Princes Avatar;
        public string Name;
        public int LovePoints,GoldPoints;
    }
    enum Princes
    { 
        PrinceOfFire,
        PrinceOfWater,
        PrinceOfEarth,
        PrinceOfAir,
        PrinceOfElectricity
    }
}
