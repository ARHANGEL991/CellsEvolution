﻿using System;
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

        public bool corect = false;




        public SettingsForm()
        {
            InitializeComponent();
        }

        private void TextBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void TextBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void TextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void TextBox3_KeyPress(object sender, KeyPressEventArgs e)
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
      public  Settings GetSettings()
        {
            Settings settings = new Settings()
            {
                dimension = Convert.ToInt32(dimension.Text),
                scale = Convert.ToInt32(scale.Text),
                lumus = !lumus.Checked,
                maxIterations = Convert.ToInt32(maxIterations.Text),
                strength = Convert.ToInt32(strength.Text),
                mutagen = Convert.ToInt32(mutagen.Text),
                end = Convert.ToInt32(end.Text)
            };
            return settings;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            corect = true;
            try
            {
                this.settings = GetSettings();
            }
            catch
            {

                MessageBox.Show(this, "Некорректный ввод! Проверте нет ли пустого поля \n или огромных значений", "Error", MessageBoxButtons.OK);


                corect = false;
            }

            if (corect)
            {
                this.Close();
            }
            
        }

        private void groupBox1_Paint(object sender, PaintEventArgs p)
        {
            GroupBox box = (GroupBox)sender;
            p.Graphics.Clear(SystemColors.Control);
            p.Graphics.DrawString(box.Text, box.Font, Brushes.Black, 0, 0);
        }

        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            corect = true;
            try
            {
                this.settings = GetSettings();
            }
            catch
            {

                MessageBox.Show(this, "Некорректный ввод! Проверте нет ли пустого поля \n или огромных значений", "Error", MessageBoxButtons.OK);

                e.Cancel = true;
                corect = false;
            }

            if (corect)
            {
                e.Cancel = false;
            }
        }
    }
}
