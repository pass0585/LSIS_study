using System;
using ClassLibrary1.Game;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class GameTest
    {
        // 1. 실패하는 테스트 케이스를 만들자
        // 2. 테스트를 성공시키는 최소한의 기능코드를 작성한다.
        // 3. 리팩토링

        [TestMethod] // 1
        public void Play_RockVsScissors()
        {
            // Arrange
            GameResult expected = GameResult.P1_WINS;

            // Act
            GameResult actual = Game.Play(Throw.ROCK, Throw.SCISSORS);

            // Assert 
            Assert.AreEqual(expected, actual);
        }

        [TestMethod] //2
        public void Play_RockVsPaper()
        {
            // Arrange
            GameResult expected = GameResult.P2_WINS;

            // Act
            GameResult actual = Game.Play(Throw.ROCK, Throw.PAPER);

            // Assert 
            Assert.AreEqual(expected, actual);
        }

        [TestMethod] //3
        public void Play_RockVsRock()
        {
            // Arrange
            GameResult expected = GameResult.DRAW;

            // Act
            GameResult actual = Game.Play(Throw.ROCK, Throw.ROCK);

            // Assert 
            Assert.AreEqual(expected, actual);
        }

        [TestMethod] // 4
        public void Play_ScissorsVsScissors()
        {
            // Arrange
            GameResult expected = GameResult.DRAW;

            // Act
            GameResult actual = Game.Play(Throw.SCISSORS, Throw.SCISSORS);

            // Assert 
            Assert.AreEqual(expected, actual);
        }

        [TestMethod] //5
        public void Play_ScissorsVsPaper()
        {
            // Arrange
            GameResult expected = GameResult.P1_WINS;

            // Act
            GameResult actual = Game.Play(Throw.SCISSORS, Throw.PAPER);

            // Assert 
            Assert.AreEqual(expected, actual);
        }

        [TestMethod] //6
        public void Play_ScissorsVsRock()
        {
            // Arrange
            GameResult expected = GameResult.P2_WINS;

            // Act
            GameResult actual = Game.Play(Throw.SCISSORS, Throw.ROCK);

            // Assert 
            Assert.AreEqual(expected, actual);
        }

        [TestMethod] // 7
        public void Play_PaperVsScissors()
        {
            // Arrange
            GameResult expected = GameResult.P2_WINS;

            // Act
            GameResult actual = Game.Play(Throw.PAPER, Throw.SCISSORS);

            // Assert 
            Assert.AreEqual(expected, actual);
        }

        [TestMethod] //8
        public void Play_PaperVsPaper()
        {
            // Arrange
            GameResult expected = GameResult.DRAW;

            // Act
            GameResult actual = Game.Play(Throw.PAPER, Throw.PAPER);

            // Assert 
            Assert.AreEqual(expected, actual);
        }

        [TestMethod] //9
        public void Play_PaperVsRock()
        {
            // Arrange
            GameResult expected = GameResult.P1_WINS;

            // Act
            GameResult actual = Game.Play(Throw.PAPER, Throw.ROCK);

            // Assert 
            Assert.AreEqual(expected, actual);
        }
    }
}
