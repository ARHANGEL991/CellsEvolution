using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CellsEvolution
{
    public class BattleField
    {
        Cell[] cells;

        private bool lumus;
       public static Point[] lookup = new Point[]                 //оглянуться
        {
            new Point(0, -1),
            new Point(1, -1),
            new Point(1, 0),
            new Point(1, 1),
            new Point(0, 1),
            new Point(-1, 1),
            new Point(-1, 0),
            new Point(-1, -1)
        };


        private  int dimension;
        private  int halfSize;

        public BattleField(int dimension, bool lumus)
        {
            this.dimension = dimension;
            this.halfSize = dimension / 2;
            cells = new Cell[dimension * dimension];
            this.lumus = lumus;
        }

        /**
         * Инициализация стартовой позиции
         */
        public void Init(int energy, String color, int direction, int strength, int mutagen, int end)
        {

            for (int i = 0; i < dimension * dimension; i++)
            {
                Cell bu = new Cell()
                {
                    clr = "000000"
                };

                if (lumus)
                {
                    bu.light = CalculateLight(i, halfSize, halfSize);
                }
                else
                {
                    bu.light = 1;
                }
                bu.behaviour = new int[23];
                bu.changed = true;
                cells[i] = bu;
            }

            Cell initial = GetCell(halfSize, halfSize);
            initial.clr = color;
            initial.direction = direction;
            initial.str = strength;
            initial.mut = mutagen;
            initial.end = end;
            initial.energy = energy;
            initial.behaviour[0] = Command.GAIN.GetCode;
            initial.changed = true;
           Point initialIndex = Normalize(halfSize, halfSize);
            cells[initialIndex.X + initialIndex.Y * dimension]= initial;
            
        }


        public Point Normalize(int x, int y)
        {
            return new Point((x + dimension) % dimension, (y + dimension) % dimension);
        }

        public Cell GetCell(int x, int y)
        {
            Point req = Normalize(x, y);
            return cells[req.X + req.Y * dimension];
        }

        public int GetDimension()
        {
            return dimension;
        }

        /**
         * Расчет коэффициента освещенности клетки поля.
         *
         * @param i  индекс клетки
         * @param xc x-координата источника освещения
         * @param yc y-координата источника освещения
         * @return рассчитанный коэффициент клетки поля
         */
        private double CalculateLight(int i, int xc, int yc)
        {
            int x = i % dimension;
            int y = i / dimension;
            int dx = xc - x;
            int dy = yc - y;
            double delta = Math.Sqrt(dx * dx + dy * dy);
            double maxDistance = Math.Sqrt(2) * xc;
            return (maxDistance - delta) / maxDistance;
        }



    }
}
