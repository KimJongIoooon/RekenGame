using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RekenGame
{
    public partial class Form1 : Form
    {
        int animationNr = 0;
        int animationEndNr = 0;
        public Form1()
        {
            InitializeComponent();
            displaySprite(animationNr);
            pnlPlayer.Size = new Size(64, 128); 
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            if(numericUpDown1.Value == 1)
            {
                playerAnimationPunch1();
            }
            if (numericUpDown1.Value == 2)
            {
                playerAnimationPunch2();
            }
            if (numericUpDown1.Value == 3)
            {
                playerAnimationPunch3();
            }
        }

        private void displaySprite(int spriteNr)
        {
            int pbX = spriteNr % 10;
            int spriteX = (spriteNr % 10) * -64;
            int spriteY = ((spriteNr - pbX) / 10) * -128;
            
            pbxPlayer.Location = new Point(spriteX, spriteY);
        }

        private void playerAnimationPunch1()
        {
            tmrAnimationPlayer.Start();
            animationNr = 20;
            animationEndNr = 24;
        }
        private void playerAnimationPunch2()
        {
            tmrAnimationPlayer.Start();
            animationNr = 25;
            animationEndNr = 27;
        }
        private void playerAnimationPunch3()
        {
            tmrAnimationPlayer.Start();
            animationNr = 28;
            animationEndNr = 29;
        }

        private void tmrAnimationPlayer_Tick(object sender, EventArgs e)
        {
            if (animationNr >= animationEndNr)
            {
                displaySprite(0);
                tmrAnimationPlayer.Stop();
            }
            else
            {
                displaySprite(animationNr);
                animationNr++;
            }
            
            
        }
    }
}
