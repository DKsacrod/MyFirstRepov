using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Module2CodingChallenge
{
    internal class Player
    {
        //Attributes (instance variable)
        private string name;
        private int score;
        private int livesLeft;

        //Constructors (generatess a new object)
        public Player(string name)
        {
            this.name = name;
        }//end method

        public Player(string name, int startingLives)
        { 
            this.name = name;
            livesLeft = startingLives;

        }//end method

        //Method = behaviors or tasks that the object can perform
        public int GetScore()
        { 
            return score;
        }//end method

        public void AddPoints(int totalPoints)
        {
            score+= totalPoints;

        }//end method

        public void Kill()
        { 
            //We make sure that they can't get negative lives
            if (livesLeft > 0)
            {
                livesLeft--;
            }
        }//end method

        public int GetLivesLeft()
        {
            return livesLeft;
        }//end method

    }//end class
}//end namespace
