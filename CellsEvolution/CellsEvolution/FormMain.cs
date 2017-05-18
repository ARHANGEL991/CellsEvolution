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
    public partial class FormMain : Form
    {
        private int dimension;

        private int scale;

        private Size size;
        private bool run;
        private Settings settings;

        SettingsForm setForm;

        private BattleField battleField;

        public FormMain()
        {
            InitializeComponent();
            
             setForm = new SettingsForm();
            settings = setForm.getSettings();
             battleField = new BattleField(settings.dimension, settings.lumus);
            battleField.Init(50, "FF0000", 0, settings.strength, settings.mutagen, settings.end);
            size = new Size(settings.dimension * settings.scale+250, settings.dimension * settings.scale+250);
            this.Size = size;
            

        }

        private  void Canvas_Paint(object sender, PaintEventArgs e)
        {


            
            Graphics g = e.Graphics;
            
            for (int i = 0; i < settings.dimension; i++)
            {
                for (int j = 0; j < settings.dimension; j++)
                {
                   Cell current = battleField.GetCell(i, j);

                    Color color = ColorTranslator.FromHtml("#"+current.ColorCode);
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

        void SetScale(int scale)
        {
            this.scale = scale;
            this.dimension = battleField.GetDimension();
            this.size = new Size(dimension * scale, dimension * scale);
            this.Size = size;
        }
        void SetBattleField(BattleField battleField)
        {
            this.battleField = battleField;
            this.dimension = battleField.GetDimension();
            this.size = new Size(dimension * scale, dimension * scale);
            this.Size = size;
        }

        private void StartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer.Start();
            run = true;
            start.Enabled=false;
            stop.Enabled=true;
            StartAutoMove();
            
        }

        private void StopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            run = false;
            timer.Stop();
            start.Enabled=true;
            stop.Enabled=false;
        }

        private async void StartAutoMove()
        {
            Settings settings = setForm.getSettings();
            battleField = new BattleField(settings.dimension, settings.lumus);
            this.battleField.Init(50, "FF0000", 0, settings.strength, settings.mutagen, settings.end);
            this.scale = settings.scale;
            //this.Size=new Size(battleField.GetDimension()*scale, battleField.GetDimension()*scale);
            
            
            MoveIterator moveIterator = new MoveIterator(battleField);

            progress.Minimum=0;
            progress.Maximum=settings.maxIterations;
            

            int iternum = 0;
            while ((run) && (iternum < settings.maxIterations))
            {
                iternum++;
                progress.Value = iternum;
                await LongOperationCellsMove(iternum, moveIterator);
            }

            start.Enabled=true;
            menuLine.Enabled=false;
            timer.Stop();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            this.playField.Invalidate();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setForm.ShowDialog();
        }


        private Task LongOperationCellsMove(int iternum, MoveIterator moveIterator)
        {
            return Task.Factory.StartNew(() =>
            {

                
                   
                    moveIterator.NextMove();
                

            });
        }
    }
}
