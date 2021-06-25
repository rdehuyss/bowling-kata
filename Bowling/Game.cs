using System;
using System.Collections.Generic;

namespace Bowling
{
    public class Game
    {
        private int score;

        private int framesCount;
        private List<Frame> frames = new List<Frame>();
        private Frame currentFrame = new Frame();

        public void Roll(int pinsDown)
        {
            this.score += pinsDown;

            currentFrame.Roll(pinsDown);

            if (currentFrame.isCompleted())
            {
                this.frames.Add(currentFrame);
                this.currentFrame = new Frame();
            }
            
            framesCount++;
        }

        public int Score()
        {
            if (framesCount > 20)
            {
                throw new InvalidOperationException();
            }
            return score;
        }
    }
}