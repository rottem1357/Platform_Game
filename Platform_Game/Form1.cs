using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Platform_Game
{
    public partial class Form1 : Form
    {
        private Map myMap;
        private Character myCharacter1;
        private Monster myMonster1;
        public Form1()
        {
            InitializeComponent();
            new Settings(pbCanvas.Size.Width, pbCanvas.Size.Height);

            myMap = new Map();
            Settings.CurrentMap = myMap.platforms;
            myCharacter1 = new Character("rottem", Settings.CharacterSize, Settings.StartingLocation);
            gameTimer.Interval = 1000 / Settings.Speed; // Changing the game time to settings speed
            gameTimer.Tick += UpdateScreen; // linking a updateScreen function to the timer
            gameTimer.Start(); // starting the timer
            myMonster1 = new Monster("1 ", Settings.CharacterSize, Settings.StartingLocation);
        }

        private void UpdateGraphics(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics; // create a new graphics class called canvas
            myMap.Draw(canvas);
            myCharacter1.Draw(canvas);
            myMonster1.Draw(canvas);    
        }
        private void UpdateScreen(object sender, EventArgs e)
        {
            // this is the Timers update screen function. 
            // each tick will run this function
            myMap.RandomCloudGeneration();
            myMap.RandomBirdGeneration();
            myMap.RandomMonsterGeneration();
            myMap.Move();
            myCharacter1.Move();
            pbCanvas.Invalidate(); // refresh the picture box and update the graphics on it
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
                myCharacter1.IsGoingRight = true;
            if (e.KeyCode == Keys.Left)
                myCharacter1.IsGoingLeft = true;
            if (e.KeyCode == Keys.Up)
                myCharacter1.Jump();
            if (e.KeyCode == Keys.Space)
                myCharacter1.Shoot();
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                myCharacter1.IsGoingRight = false;
            }
            if (e.KeyCode == Keys.Left)
            {
                myCharacter1.IsGoingLeft = false;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void P1MpBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void P1HpBar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
