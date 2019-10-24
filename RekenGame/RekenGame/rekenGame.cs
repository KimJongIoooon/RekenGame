using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RekenGame
{
    class RekenGame
    {

        public int Number1;
        public int Number2;
        int Answer;
        public int HealthPlayer;
        public int HealthEnemy;
        public bool TurnPlayer = false;

        public RekenGame()
        {
            NextSom();
            HealthEnemy = 100;
            HealthPlayer = 100;
        }

        public void StartGame()
        {

        }
        void NextSom()
        {
            Random random = new Random();
            Number1 = random.Next(2,9);
            Number2 = random.Next(2, 9);
            Answer = Number1 * Number2;
        }
        public bool SendAnswer(int input)
        {
            bool correct = false;
            if(Answer == input)
            {
                HealthEnemy = HealthEnemy - 20;
                correct = true;
            } else
            {
                HealthPlayer = HealthPlayer - 10;
                correct =  false;
            }

            NextSom();
            return correct;
        }
    }
}
