using System;
using System.Collections.Generic;

namespace Bowling
{
    public class Game
    {
        private List<Frame> frames = new List<Frame>();
        private Frame currentFrame = new Frame();

        public void Roll(int pinsDown)
        {
            currentFrame.Roll(pinsDown);

            if (currentFrame.isCompleted())
            {
                this.frames.Add(currentFrame);
                this.currentFrame = new Frame();
            } 
        }

        public int Score()
        {
            int score = 0;

            for (int i = 0; i < frames.Count; i++)
            {
                var frame = frames[i];

                score += frame.Score();
                if (frame.isSpare())
                {
                    score += frames[i + 1].FirstRoll ?? 0;
                }
            }
            if (frames.Count > 10)
            {
                throw new InvalidOperationException();
            }
            return score;
        }
    }
}