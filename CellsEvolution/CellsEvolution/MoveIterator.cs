using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CellsEvolution
{
   public class MoveIterator
    {
        public BattleField battleField;

       public  Engine engine;

        public int dimension;

        public int totalCell;
        public Randomize rand = new Randomize();

        public MoveIterator(BattleField battleField)
        {
            this.dimension = battleField.GetDimension();
            this.battleField = battleField;
            this.engine = new Engine(battleField);
            totalCell = dimension * dimension;
        }

        public void NextMove()
        {
            List<int> processed = new List<int>(totalCell);
            while (processed.Count() < totalCell)
            {
                int x = rand.GetRandom(0, dimension - 1);
                int y = rand.GetRandom(0, dimension - 1);
                processed.Add(y * dimension + x);
                if ((!battleField.GetCell(x, y).clr.Equals("000000")) && (!battleField.GetCell(x, y).clr.Equals("FFFFFF")))
                {
                    engine.Process(x, y);
                }
            }
        }
    }
}
