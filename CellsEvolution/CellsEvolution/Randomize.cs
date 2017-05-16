using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CellsEvolution
{
  public  class Randomize
    {
       public Random rand = new Random();
        

        public  int GetRandom(int min, int max)
        {
            return rand.Next(min,max);
        }

        public  String GetRandomColorCode()
        {
            return GetRandom(1, 16777214).ToString("X");
        }

        public  int GetRandomPercent()
        {
            return GetRandom(0, 100);
        }

        public  int GetRandomDirection()
        {
            return GetRandom(0, 7);
        }
    }
}
