using System;
using Xunit;

namespace Bowling.Tests
{
    public class GameTests
    {
        private Game game = new Game();
        
        [Fact]
        public void RollGutter()
        {
            RollFrame(0, 0);
            Assert.Equal(0, game.Score());
        }
        
        [Fact]
        public void RollOnePin()
        {
            RollFrame(1, 0);
            Assert.Equal(1, game.Score());
        }

        private void RollFrame(int firstRoll, int secondRoll)
        {
            game.Roll(firstRoll);
            game.Roll(secondRoll);
        }
    }
}