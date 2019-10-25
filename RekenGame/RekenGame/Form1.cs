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

        int countDown = 5;
        Character player;
        Character enemy;
        bool answered;
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
            } else
            {
                lblMessage.Text = $"Counter the attack! {countDown}";
            }
            if (game.HealthPlayer > 0 && game.HealthEnemy > 0)
            {
                prgEnemyHealth.Value = game.HealthEnemy;
                prgPlayerHealth.Value = game.HealthPlayer;
                lblSom.Text = $"{game.Number1.ToString()} * {game.Number2.ToString()} = ?";
            } else
            {
                if(game.HealthEnemy <= 0)
                {
                    prgEnemyHealth.Value = 0;
                }
                if (game.HealthPlayer<= 0)
                {
                    prgPlayerHealth.Value = 0;
                }
                GameOver();
            }
        }
        private void GameOver()
        {
            tmrCountDown.Stop();
            tmrTurn.Stop();

            btnEnter.Enabled = false;
            if (game.HealthEnemy <= 0)
            {
                lblMessage.Text = "You Won!";
                
            }
            if (game.HealthPlayer <= 0)
            {
                lblMessage.Text = "You Lost!";
            }
        }
        private void btnTest_Click(object sender, EventArgs e)
        {
            UpdateGui();
            btnTest.Visible = false;

        }
        
        private void tmrAnimationPlayer_Tick(object sender, EventArgs e)
        {
            pbxPlayer.Location = player.NextFrame();
        }

        private void tmrAnimationEnemy_Tick(object sender, EventArgs e)
        {
            pbxEnemy.Location = enemy.NextFrame();
        }

        
        private void SendAnswer()
        {
            tmrCountDown.Stop();
            int playerAnswer = Convert.ToInt32(tbxInput.Text);
            if (game.TurnPlayer)
            {
                //playerAnimationPunch1();

                player.StartAnimationPunch();
                tmrAnimationPlayer.Start();
            }
            else
            {
                enemy.StartAnimationPunch();
                tmrAnimationEnemy.Start();
            }
            answered = true;
            bool answeredCorrectly = game.SendAnswer(playerAnswer);
            UpdateGui();

            if (answeredCorrectly)
            {
                if (game.TurnPlayer)
                {
                    lblMessage.Text = "You Hit the enemy!";
                    
                } else
                {
                    lblMessage.Text = "You Dodged the attack!";
                } 
            }
            else
            {
                if (game.TurnPlayer)
                {
                    lblMessage.Text = "You missed!";
                    
                }
                else
                {
                    lblMessage.Text = "You got hit!";
                }
            }
            tmrTurn.Stop();
            tmrTurn.Interval = 1300;
            tmrTurn.Start();
        }

        private void tmrTurn_Tick(object sender, EventArgs e)
        {
            game.NextTurn();
            answered = false;
            if (!game.TurnPlayer)
            {
                tmrCountDown.Start();
            }
            tmrTurn.Stop();
            UpdateGui();
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

        private void TmrCountDown_Tick(object sender, EventArgs e)
        {
            countDown--;
            if(countDown <= -1)
            {
                countDown = 5;
                SendAnswer();
                tmrCountDown.Stop();
            }
            else
            {
                UpdateGui();
            }
            
        }
        private void btnEnter_Click(object sender, EventArgs e)
        {
            SendAnswer();
        }
    }
}
