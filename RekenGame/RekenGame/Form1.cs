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
        RekenGame game;
        int animationNr = 0;
        int animationEndNr = 0;
        public Form1()
        {
            game = new RekenGame();
            
            
            InitializeComponent();
            displaySprite(animationNr);
            InitPlayerCharacter();
            InitEnemyCharacter();
        }
        private void InitPlayerCharacter()
        {
            pnlPlayer.Size = new Size(64, 128);
            pbxPlayer.Image = Properties.Resources.advnt_full;
            pbxPlayer.Size = new Size(640, 1280);
        }
        private void InitEnemyCharacter()
        {
            pnlEnemy.Size = new Size(64, 128);
            pbxEnemy.Image = Properties.Resources.skeletonBaseFlipped;
            pbxEnemy.Size = new Size(640, 1280);
        }

        private void UpdateGui()
        {
            prgEnemyHealth.Value = game.HealthEnemy;
            prgPlayerHealth.Value = game.HealthPlayer;
            lblSom.Text = $"{game.Number1.ToString()} * {game.Number2.ToString()} = ?";
        }
        private void btnTest_Click(object sender, EventArgs e)
        {
            UpdateGui();

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
        
        private void enemyAnimationPunch1()
        {

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

        private void btnEnter_Click(object sender, EventArgs e)
        {
            int playerAnswer = Convert.ToInt32(tbxInput.Text);
            bool answeredCorrectly = game.SendAnswer(playerAnswer);
            if (game.TurnPlayer)
            {
                playerAnimationPunch1();
            } else
            {
                playerAnimationPunch1();
            }
            UpdateGui();

        }

        private void turnTimer_Tick(object sender, EventArgs e)
        {

        }
    }
}
