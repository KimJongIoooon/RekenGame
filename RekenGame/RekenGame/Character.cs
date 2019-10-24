using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RekenGame
{
    class Character
    {
        public bool isEnemy;
        public bool isPlayer;
        public int animationNr;
        public int animationEnd; 
        
        public Character(bool isEnemy, bool isPlayer)
        {
            this.isEnemy = isEnemy;
            this.isPlayer = isPlayer;
        }
        private Point DisplaySpritePlayer(int spriteNr)
        {
            int pbX = spriteNr % 10;
            int spriteX = (spriteNr % 10) * -96; 
            int spriteY = ((spriteNr - pbX) / 10) * -192;
            return new Point(spriteX, spriteY);
        }

        public void StartAnimationPunch()
        {
            if (isPlayer)
            {
                animationNr = 20;
                animationEnd = 24;
            }
            if (isEnemy)
            {
                animationNr = 29;
                animationEnd = 25;
            }
        }

        public Point NextFrame()
        {
            Point point = new Point();
            if (isEnemy)
            {
                if (animationNr <= animationEnd)
                {
                    point = DisplaySpritePlayer(9);
                    //animationNr = 0;
                }
                else
                {
                    point = DisplaySpritePlayer(animationNr);
                    animationNr--;
                }
            }
            if (isPlayer)
            {
                if (animationNr >= animationEnd)
                {
                    point = DisplaySpritePlayer(0);
                    //animationNr = 0;
                }
                else
                {
                    point = DisplaySpritePlayer(animationNr);
                    animationNr++;
                }
                
            }
            return point;
        }
    }
}
