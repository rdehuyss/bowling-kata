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
        
        [Fact]
        public void RollCompleteGameWithOnePinPerFrame()
        {
            RollFrame(1, 0);
            RollFrame(1, 0);
            RollFrame(1, 0);
            RollFrame(1, 0);
            RollFrame(1, 0);
            
            RollFrame(1, 0);
            RollFrame(1, 0);
            RollFrame(1, 0);
            RollFrame(1, 0);
            RollFrame(1, 0);
            
            RollFrame(1, 0);
            Assert.Throws<InvalidOperationException>( () => game.Score());
        }

        [Fact]
        public void SpareUsesScoresFromNextRoll()
        {
            RollFrame(2, 8);
            RollFrame(1, 0);
            RollFrame(1, 0);
            RollFrame(1, 0);
            RollFrame(1, 0);
            
            RollFrame(1, 0);
            RollFrame(1, 0);
            RollFrame(1, 0);
            RollFrame(1, 0);
            RollFrame(1, 0);
            Assert.Equal(20, game.Score());
        }

        private void RollFrame(int firstRoll, int secondRoll)
        {
            game.Roll(firstRoll);
            game.Roll(secondRoll);
        }
    }
}