using System;
using GameLibrary.Abstract;
using GameLibrary.Concrete;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace TestGameLibrary
{
    [TestClass]
    public class MainGameTest
    {
        [TestMethod]
        public void CanIStartNewGame() {
            IGame game = GameLauncher.StartNewGame();
            Assert.IsTrue(game.IsStarted);
        }

        [TestMethod]
        public void CanIStopGame() {
            IGame game = GameLauncher.StartNewGame();
            GameLauncher.StopTheGame(game);
            Assert.IsFalse(game.IsStarted);
        }
    }

}
