namespace CellsEvolution
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lumus = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dimension = new System.Windows.Forms.TextBox();
            this.scale = new System.Windows.Forms.TextBox();
            this.maxIterations = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.end = new System.Windows.Forms.TextBox();
            this.mutagen = new System.Windows.Forms.TextBox();
            this.strength = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Размер игрового поля";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Размер клетки";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Число итераций";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Базовая сила";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Мутагенность";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 26);
            this.label6.TabIndex = 5;
            this.label6.Text = "Порог энергии\r\n для размножения";
            // 
            // lumus
            // 
            this.lumus.AutoSize = true;
            this.lumus.Location = new System.Drawing.Point(33, 148);
            this.lumus.Name = "lumus";
            this.lumus.Size = new System.Drawing.Size(155, 17);
            this.lumus.TabIndex = 6;
            this.lumus.Text = "Равномерное освещение";
            this.lumus.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dimension);
            this.groupBox1.Controls.Add(this.scale);
            this.groupBox1.Controls.Add(this.maxIterations);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(23, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 171);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Настройки поля";
            // 
            // dimension
            // 
            this.dimension.Location = new System.Drawing.Point(137, 30);
            this.dimension.Name = "dimension";
            this.dimension.Size = new System.Drawing.Size(100, 20);
            this.dimension.TabIndex = 12;
            this.dimension.Text = "150";
            this.dimension.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox6_KeyPress);
            // 
            // scale
            // 
            this.scale.Location = new System.Drawing.Point(137, 67);
            this.scale.Name = "scale";
            this.scale.Size = new System.Drawing.Size(100, 20);
            this.scale.TabIndex = 11;
            this.scale.Text = "3";
            this.scale.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox5_KeyPress);
            // 
            // maxIterations
            // 
            this.maxIterations.Location = new System.Drawing.Point(137, 107);
            this.maxIterations.Name = "maxIterations";
            this.maxIterations.Size = new System.Drawing.Size(100, 20);
            this.maxIterations.TabIndex = 10;
            this.maxIterations.Text = "1000";
            this.maxIterations.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.end);
            this.groupBox2.Controls.Add(this.mutagen);
            this.groupBox2.Controls.Add(this.strength);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lumus);
            this.groupBox2.Location = new System.Drawing.Point(285, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(243, 171);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Настройки клетки";
            // 
            // end
            // 
            this.end.Location = new System.Drawing.Point(128, 107);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(100, 20);
            this.end.TabIndex = 9;
            this.end.Text = "100";
            this.end.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // mutagen
            // 
            this.mutagen.Location = new System.Drawing.Point(128, 63);
            this.mutagen.Name = "mutagen";
            this.mutagen.Size = new System.Drawing.Size(100, 20);
            this.mutagen.TabIndex = 8;
            this.mutagen.Text = "50";
            this.mutagen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // strength
            // 
            this.strength.Location = new System.Drawing.Point(128, 22);
            this.strength.Name = "strength";
            this.strength.Size = new System.Drawing.Size(100, 20);
            this.strength.TabIndex = 7;
            this.strength.Text = "1";
            this.strength.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // button1
            // 
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(236, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Применить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 252);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox lumus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox dimension;
        private System.Windows.Forms.TextBox scale;
        private System.Windows.Forms.TextBox maxIterations;
        private System.Windows.Forms.TextBox end;
        private System.Windows.Forms.TextBox mutagen;
        private System.Windows.Forms.TextBox strength;
    }
}