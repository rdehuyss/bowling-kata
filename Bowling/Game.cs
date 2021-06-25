using System;

namespace Bowling
{
    public class Game
    {
        private int score;
        private int frames;

        public void Roll(int pinsDown)
        {
            this.score += pinsDown;

            frames++;
        }

        public int Score()
        {
            if (frames >= 10)
            {
                throw new InvalidOperationException();
            }
            return score;
        }
    }
}