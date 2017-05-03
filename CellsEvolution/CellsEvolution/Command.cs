using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CellsEvolution
{
    public class Command
    {
        private readonly string about;
        private readonly int code;
        public static readonly Command NOOP = new Command(0, "No operations");
        public static readonly Command GAIN = new Command(23, "Gain the sunlight");
        public static readonly Command MOVE = new Command(20, "Move to another cell");
        public static readonly Command TURN_LEFT = new Command(21, "Turn left");
        public static readonly Command TURN_RIGHT = new Command(26, "Turn right");
        public static readonly Command EAT = new Command(22, "FOOD !!!");
        public static readonly Command ATTACK = new Command(24, "Kill'em'All");
        public static readonly Command OBSERVE = new Command(25, "Look Out");

        public Command(int code, string about)
        {
            this.code = code;
            this.about = about;
        }

        public int GetCode
        {
            get { return code; }
        }
    }
}
