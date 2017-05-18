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
    public partial class SettingsForm : Form


    {


        public Settings settings;






        public SettingsForm()
        {
            InitializeComponent();
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        public void SetSettings(Settings settings)
        {
            this.settings = settings;

            dimension.Text = settings.dimension.ToString();
            scale.Text = settings.scale.ToString();
            maxIterations.Text = settings.maxIterations.ToString();
            lumus.Checked = settings.lumus;
            strength.Text = settings.strength.ToString();
            mutagen.Text = settings.mutagen.ToString();
            end.Text = settings.end.ToString();



        }
      public  Settings getSettings()
        {
            Settings settings = new Settings()
            {
                dimension = Convert.ToInt16(dimension.Text),
                scale = Convert.ToInt16(scale.Text),
                lumus = !lumus.Checked,
                maxIterations = Convert.ToInt16(maxIterations.Text),
                strength = Convert.ToInt16(strength.Text),
                mutagen = Convert.ToInt16(mutagen.Text),
                end = Convert.ToInt16(end.Text)
            };
            return settings;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.settings = getSettings();
            this.Close();
        }
    }
}
