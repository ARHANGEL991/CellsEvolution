using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CellsEvolution
{
   public class Cell
     {


            static int actlim = 20;                       //максимальное количество действий
            static int comnum = 6;                       //количество доступных команд
            static int relsense = 5;                    //how much relative can differ
            static int gainbase = 5;                   //дополнительный прирост получения энергии от фотосинтеза

            public bool changed;
                                                    // Параметры клетки
            public int str;
            public int end;
            public int mut;
            public String clr;

            public double energy;
            public double light;                            // Освещеннойсть клетки
            public int direction;                          // Направление перемещения или атаки
            public int action = 0;                         // Номер отрабатываемой команды

            public int ticks;                              //Время жизни клетки в ходах
            public int[] behaviour = new int[23];          // последовательность действий клетки


             public  Cell()
             {
                this.clr = "000000";
             }

        int MyAction
        {
            get
            {
                action %= actlim;
                int actionCode = behaviour[action];
                action++;
                return actionCode;
            }
        }

        void Gain()
            {
                energy += gainbase * light;
            }

            void Turn(int dir)
            {
                if (dir % 2 == 0)
                {
                    direction = (direction + 1) % 8;
                }
                else
                {
                    direction = (direction + 7) % 8;
                }
            }

        public String ColorCode
        {
            get
            {
                return clr;
            }
        }
     }

}

