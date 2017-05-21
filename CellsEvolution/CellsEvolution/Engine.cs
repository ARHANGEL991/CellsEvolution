using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CellsEvolution
{
   public class Engine
    {

        private  String EMPTY_CELL = "000000";
    private  String CORPSE_CELL = "FFFFFF";

    public BattleField battleField;
        private Randomize rand = new Randomize();

       public Engine(BattleField battleField)
        {
            this.battleField = battleField;
        }

     public   void Process(int x, int y)
        {
             Cell target = battleField.GetCell(x, y);
             
            
            if (target.energy >= target.end)
            {
                Breed(x, y, target);
                return;
            }

            if (target.energy <= 0)
            {
                Die(target);
                return;
            }

            //Выполняем другие действия
            bool nextMove = true;
            int counter = 0;
            while (nextMove)
            {
                nextMove = counter < Cell.actlim;

                target.energy -= 1 + (float)target.str / 10;
                if (target.energy <= 0)
                {
                    return;
                }
                counter++;
                int commandCode = target.MyAction;
                switch (commandCode)
                {
                    case 20:
                        Move(x, y, target);
                        nextMove = false;
                        break;
                    case 21:
                        target.Turn(target.MyAction);
                        break;
                    case 22:
                        Eat(x, y, target);
                        nextMove = false;
                        break;
                    case 23:
                        target.Gain();
                        nextMove = false;
                        break;
                    case 24:
                        Attack(x, y, target);
                        nextMove = false;
                        break;
                    case 25:
                        Observe(x, y, target);
                        break;
                    default:
                        target.action = commandCode;
                        break;
                }
            }
        }

        private void Observe(int x, int y, Cell observer)
        {
            Point dir = BattleField.lookup[observer.direction];
            Cell target = battleField.GetCell(x + dir.X, y + dir.X);
            if (target.clr.Equals(CORPSE_CELL))
            {
                Eat(x, y, observer);
            }
            else if (!target.clr.Equals(EMPTY_CELL))
            {
                if (observer.clr.CompareTo(target.clr) >= Cell.relsense)
                {
                    Attack(x, y, observer);
                }
                else
                {
                    observer.Gain();
                }
            }
            else
            {
                Move(x, y, observer);
            }
        }

        private void Attack(int x, int y, Cell attacker)
        {
            Point dir = BattleField.lookup[attacker.direction];
            Cell defense = battleField.GetCell(x + dir.X, y + dir.Y);
            if (attacker.clr.CompareTo(defense.clr) >= Cell.relsense)
                if (rand.GetRandom(0, attacker.str + defense.str) <= attacker.str)
                {
                    Corpse(defense);
                }
                else
                {
                    Corpse(attacker);
                }
        }

        private void Eat(int x, int y, Cell devourer)
        {
            List<Cell> victims = FindNeighbors(x, y, CORPSE_CELL);
            if (victims.Count > 0)
            {
                Cell victim = victims[(rand.GetRandom(0, victims.Count() - 1))];
                devourer.energy += victim.energy / 2;
                Die(victim);
            }
        }

        private void Move(int x, int y, Cell source)
        {
            List<Cell> targets = FindNeighbors(x, y, EMPTY_CELL);
            if (targets.Count() > 0)
            {
                Cell dest = targets[(rand.GetRandom(0, targets.Count() - 1))];
                Copy(source, dest);
                dest.changed = true;
                Die(source);
            }
        }

        private void Breed(int x, int y, Cell parent)
        {
            List<Cell> emptyCells = FindNeighbors(x, y, EMPTY_CELL);

            if (emptyCells.Count==0)
            {
                Corpse(parent);
                return;
            }
            int pos = rand.GetRandom(0, emptyCells.Count() - 1);
            Cell newCell = emptyCells[pos];
            parent.energy = parent.energy / 2;
            Copy(parent, newCell);

            newCell.direction = rand.GetRandom(0, 7);
            newCell.action = 0;
            newCell.ticks = 0;
            newCell.changed = true;
            if (rand.GetRandom(0, 1000) < parent.mut)
                Mutate(newCell);
        }

        private void Copy(Cell src, Cell dst)
        {
            dst.energy = src.energy;
            dst.str = src.str;
            dst.end = src.end;
            dst.mut = src.mut;
            dst.clr = src.clr;
            dst.direction = src.direction;
            dst.action = src.action;
             Array.Copy(src.behaviour, dst.behaviour, Cell.actlim);
        }

        private void Mutate(Cell cell)
        {
            cell.str += cell.str > 1 ? rand.GetRandom(-1, 1) : rand.GetRandom(0, 1);
            cell.end += rand.GetRandom(-1, 1);

            cell.clr = rand.GetRandomColorCode();
            cell.mut += rand.GetRandom(-1, 1);

            //мутация поведения
            int mutnum = rand.GetRandom(0, Cell.actlim - 1);
            cell.behaviour[mutnum] = rand.GetRandom(20, 25);
        }

        private void Die(Cell target)
        {
            target.clr = "000000";
            target.changed = true;
        }

        private void Corpse(Cell target)
        {
            target.clr = "FFFFFF";
            target.changed = true;
        }

        private List<Cell> FindNeighbors(int x, int y, String code)
        {
            List<Cell> cells = new List<Cell>();
            foreach (Point dd in  BattleField.lookup)
            {
                Cell cell = battleField.GetCell(x + dd.X, y + dd.Y);
                if (cell.clr.Equals(code)) //todo метка занятости клетки
                    cells.Add(cell);
            }
            return cells;
        }
    }
}
