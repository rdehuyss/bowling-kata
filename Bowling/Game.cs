using System;

namespace Bowling
{
    public class Game
    {
        private int score;

        public void Roll(int pinsDown)
        {
            this.score += pinsDown;
        }

        public int Score()
        {
            return score;
        }
    }
}