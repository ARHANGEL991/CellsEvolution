using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CellsEvolution
{
    public partial class FormMain : Form
    {
        private int dimension;

        private int scale;

        private Size size;
        

        private BattleField battleField;

        public FormMain()
        {
            InitializeComponent();
            size = new Size(dimension*scale, dimension * scale);
            Canvas.Size = size;

        }

        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            for (int i = 0; i < dimension; i++)
            {
                for (int j = 0; j < dimension; j++)
                {
                    Cell current = battleField.GetCell(i, j);

                    Color color = ColorTranslator.FromHtml(current.ColorCode);
                    SolidBrush brush = new SolidBrush(color);
                    if (scale > 3)
                    {
                        g.DrawRectangle(new Pen(color),i * scale, j * scale, scale - 1, scale - 1);
                        g.FillRectangle(brush,i * scale, j * scale, scale - 1, scale - 1);
                    }
                    else
                    {
                        g.DrawRectangle(new Pen(color),i * scale, j * scale, scale - 1, scale - 1);
                    }
                    current.changed = false;
                }
            }

        }
    }
}
