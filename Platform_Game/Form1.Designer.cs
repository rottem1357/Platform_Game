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
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.Name1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Character1Name = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Kills1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.MP1 = new System.Windows.Forms.Label();
            this.P1MpBar = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.HP1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.P1HpBar = new System.Windows.Forms.PictureBox();
            this.pbCanvas = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.homePageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.P1MpBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P1HpBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
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
            // Character1Name
            // 
            this.Character1Name.AutoSize = true;
            this.Character1Name.Location = new System.Drawing.Point(80, 45);
            this.Character1Name.Name = "Character1Name";
            this.Character1Name.Size = new System.Drawing.Size(41, 20);
            this.Character1Name.TabIndex = 3;
            this.Character1Name.Text = "TBD";
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
            this.panel1.Controls.Add(this.Character1Name);
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
            // pbCanvas
            // 
            this.pbCanvas.BackColor = System.Drawing.Color.SkyBlue;
            this.pbCanvas.Location = new System.Drawing.Point(0, 36);
            this.pbCanvas.Name = "pbCanvas";
            this.pbCanvas.Size = new System.Drawing.Size(900, 800);
            this.pbCanvas.TabIndex = 0;
            this.pbCanvas.TabStop = false;
            this.pbCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.UpdateGraphics);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.homePageToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1200, 33);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(89, 29);
            this.exitToolStripMenuItem.Text = "options";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(151, 34);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(151, 34);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.ExitToolStripMenuItem1_Click);
            // 
            // homePageToolStripMenuItem
            // 
            this.homePageToolStripMenuItem.Name = "homePageToolStripMenuItem";
            this.homePageToolStripMenuItem.Size = new System.Drawing.Size(122, 29);
            this.homePageToolStripMenuItem.Text = "Home page";
            this.homePageToolStripMenuItem.Click += new System.EventHandler(this.HomePageToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 900);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbCanvas);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Platform Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.P1MpBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P1HpBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCanvas;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label Name1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Character1Name;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox P1MpBar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label HP1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox P1HpBar;
        private System.Windows.Forms.Label Kills1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label MP1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem homePageToolStripMenuItem;
    }
}

