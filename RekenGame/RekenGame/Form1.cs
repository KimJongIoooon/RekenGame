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
        int animationNrPlayer = 0;
        int animationEndNr = 0;
        Character player;
        Character enemy;
        public Form1()
        {
            InitializeComponent();

            game = new RekenGame();
            player = new Character(false, true);
            enemy = new Character(true, false);
            InitPlayerCharacter();
            InitEnemyCharacter();
        }
        

        private void UpdateGui()
        {
            if(game.TurnPlayer == true)
            {
                lblMessage.Text = "Attack!";
            }
            prgEnemyHealth.Value = game.HealthEnemy;
            prgPlayerHealth.Value = game.HealthPlayer;
            lblSom.Text = $"{game.Number1.ToString()} * {game.Number2.ToString()} = ?";
        }
        private void btnTest_Click(object sender, EventArgs e)
        {
            UpdateGui();

        }

        private void playerAnimationPunch1()
        {
            tmrAnimationPlayer.Start();
            animationNrPlayer = 20;
            animationEndNr = 24;
        }
        
        private void enemyAnimationPunch1()
        {

        }

        private void tmrAnimationPlayer_Tick(object sender, EventArgs e)
        {
            pbxPlayer.Location = player.NextFrame();
        }

        private void tmrAnimationEnemy_Tick(object sender, EventArgs e)
        {
            pbxEnemy.Location = enemy.NextFrame();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            int playerAnswer = Convert.ToInt32(tbxInput.Text);
            bool answeredCorrectly = game.SendAnswer(playerAnswer);
            if (game.TurnPlayer)
            {
                //playerAnimationPunch1();
               
                player.StartAnimationPunch();
                tmrAnimationPlayer.Start();
            } else
            {
                enemy.StartAnimationPunch();
                tmrAnimationEnemy.Start();
            }
            UpdateGui();

        }

        private void turnTimer_Tick(object sender, EventArgs e)
        {

        }
        private void InitPlayerCharacter()
        {
            pnlPlayer.Size = new Size(96, 192);
            pbxPlayer.Image = Properties.Resources.advnt_full;
            pbxPlayer.Size = new Size(960, 1920); 
        }
        private void InitEnemyCharacter()
        {
            pnlEnemy.Size = new Size(96, 192);
            pbxEnemy.Image = Properties.Resources.skeletonBaseFlipped;
            pbxEnemy.Size = new Size(960, 1920);
            int spriteNr = 9;
            int pbX = spriteNr % 10;
            int spriteX = (spriteNr % 10) * -96;
            int spriteY = ((spriteNr - pbX) / 10) * -192;
            pbxEnemy.Location = new Point(spriteX, spriteY);
        }


    }
}
