namespace Platform_Game
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.pbCanvas = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.Name1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Kills1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.MP1 = new System.Windows.Forms.Label();
            this.P1MpBar = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.HP1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.P1HpBar = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Kills2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.MP2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.HP2 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label16 = new System.Windows.Forms.Label();
            this.Name2 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.P1MpBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P1HpBar)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCanvas
            // 
            this.pbCanvas.BackColor = System.Drawing.Color.SkyBlue;
            this.pbCanvas.Location = new System.Drawing.Point(0, 0);
            this.pbCanvas.Name = "pbCanvas";
            this.pbCanvas.Size = new System.Drawing.Size(900, 800);
            this.pbCanvas.TabIndex = 0;
            this.pbCanvas.TabStop = false;
            this.pbCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.UpdateGraphics);
            // 
            // Name1
            // 
            this.Name1.AutoSize = true;
            this.Name1.Location = new System.Drawing.Point(4, 9);
            this.Name1.Name = "Name1";
            this.Name1.Size = new System.Drawing.Size(69, 20);
            this.Name1.TabIndex = 1;
            this.Name1.Text = "Player 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "TBD";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Kills1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.MP1);
            this.panel1.Controls.Add(this.P1MpBar);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.HP1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.P1HpBar);
            this.panel1.Controls.Add(this.Name1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(922, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 292);
            this.panel1.TabIndex = 4;
            // 
            // Kills1
            // 
            this.Kills1.AutoSize = true;
            this.Kills1.Location = new System.Drawing.Point(84, 248);
            this.Kills1.Name = "Kills1";
            this.Kills1.Size = new System.Drawing.Size(41, 20);
            this.Kills1.TabIndex = 11;
            this.Kills1.Text = "TBD";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 248);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Kills:";
            // 
            // MP1
            // 
            this.MP1.AutoSize = true;
            this.MP1.Location = new System.Drawing.Point(112, 201);
            this.MP1.Name = "MP1";
            this.MP1.Size = new System.Drawing.Size(41, 20);
            this.MP1.TabIndex = 9;
            this.MP1.Text = "TBD";
            // 
            // P1MpBar
            // 
            this.P1MpBar.Location = new System.Drawing.Point(8, 196);
            this.P1MpBar.Name = "P1MpBar";
            this.P1MpBar.Size = new System.Drawing.Size(255, 26);
            this.P1MpBar.TabIndex = 8;
            this.P1MpBar.TabStop = false;
            this.P1MpBar.Paint += new System.Windows.Forms.PaintEventHandler(this.P1MpBar_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "MP";
            // 
            // HP1
            // 
            this.HP1.AutoSize = true;
            this.HP1.Location = new System.Drawing.Point(108, 125);
            this.HP1.Name = "HP1";
            this.HP1.Size = new System.Drawing.Size(41, 20);
            this.HP1.TabIndex = 6;
            this.HP1.Text = "TBD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "HP";
            // 
            // P1HpBar
            // 
            this.P1HpBar.Location = new System.Drawing.Point(8, 118);
            this.P1HpBar.Name = "P1HpBar";
            this.P1HpBar.Size = new System.Drawing.Size(255, 27);
            this.P1HpBar.TabIndex = 4;
            this.P1HpBar.TabStop = false;
            this.P1HpBar.Paint += new System.Windows.Forms.PaintEventHandler(this.P1HpBar_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Kills2);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.MP2);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.HP2);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.Name2);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Location = new System.Drawing.Point(922, 320);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(266, 292);
            this.panel2.TabIndex = 5;
            // 
            // Kills2
            // 
            this.Kills2.AutoSize = true;
            this.Kills2.Location = new System.Drawing.Point(84, 248);
            this.Kills2.Name = "Kills2";
            this.Kills2.Size = new System.Drawing.Size(41, 20);
            this.Kills2.TabIndex = 11;
            this.Kills2.Text = "TBD";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 248);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 20);
            this.label11.TabIndex = 10;
            this.label11.Text = "Kills:";
            // 
            // MP2
            // 
            this.MP2.AutoSize = true;
            this.MP2.Location = new System.Drawing.Point(112, 201);
            this.MP2.Name = "MP2";
            this.MP2.Size = new System.Drawing.Size(41, 20);
            this.MP2.TabIndex = 9;
            this.MP2.Text = "TBD";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(8, 196);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(255, 26);
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(4, 164);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 20);
            this.label13.TabIndex = 7;
            this.label13.Text = "MP";
            // 
            // HP2
            // 
            this.HP2.AutoSize = true;
            this.HP2.Location = new System.Drawing.Point(108, 125);
            this.HP2.Name = "HP2";
            this.HP2.Size = new System.Drawing.Size(41, 20);
            this.HP2.TabIndex = 6;
            this.HP2.Text = "TBD";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(4, 95);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(31, 20);
            this.label15.TabIndex = 5;
            this.label15.Text = "HP";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(8, 118);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(255, 27);
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(4, 9);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(69, 20);
            this.label16.TabIndex = 1;
            this.label16.Text = "Player 2:";
            // 
            // Name2
            // 
            this.Name2.AutoSize = true;
            this.Name2.Location = new System.Drawing.Point(80, 45);
            this.Name2.Name = "Name2";
            this.Name2.Size = new System.Drawing.Size(41, 20);
            this.Name2.TabIndex = 3;
            this.Name2.Text = "TBD";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(4, 45);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(55, 20);
            this.label18.TabIndex = 2;
            this.label18.Text = "Name:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 900);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbCanvas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.P1MpBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P1HpBar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCanvas;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label Name1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox P1MpBar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label HP1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox P1HpBar;
        private System.Windows.Forms.Label Kills1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label MP1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Kills2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label MP2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label HP2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label Name2;
        private System.Windows.Forms.Label label18;
    }
}

