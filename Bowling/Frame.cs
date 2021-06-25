namespace Bowling
{
    internal class Frame
    {
        public int? FirstRoll { get; set; }
        public int? SecondRoll { get; set; }

        public void Roll(int score)
        {
            if (this.FirstRoll == null)
            {
                this.FirstRoll = score;
            }
            else
            {
                this.SecondRoll = score;
            }
        }

        public bool isCompleted()
        {
            return this.FirstRoll != null && this.SecondRoll != null;
        }
    }
}