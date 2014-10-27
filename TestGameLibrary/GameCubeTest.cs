using System;
using GameLibrary.Abstract;
using GameLibrary.Concrete;
using GameLibrary.GameTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestGameLibrary {
    [TestClass]
    public class GameCubeTest {
        private IGame game;
        [TestInitialize]
        public void SetGamePrepare() {
            game = new Game();
        }
        [TestMethod]
        public void CanAddOneThrow() {
            GameCube gc = game.Cubes[0];
            gc.PerformOneThrow();
            int actual = gc.HowManyThrowWas();
            int expepcted = 1;
            Assert.AreEqual(expepcted, actual);
        }

        [TestMethod]
        public void CanGetLastResult() {

            var gc = game.Cubes[0];
            int expected = 3;
            gc.PerformOneThrow(expected);
            int last = gc.GetLastThrowResult();
            Assert.AreEqual(expected, last);
        }

        [TestMethod]
        public void CanGetCountThrows() {
            GameCube gameCube =game.Cubes[0];
            gameCube.PerformOneThrow();
            gameCube.PerformOneThrow();
            gameCube.PerformOneThrow();
            int expected = 3;
            int actual = gameCube.HowManyThrowWas();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CanGetWhenNoAnyThrow() {
            GameCube gameCube = game.Cubes[0];
            int expected = 0;
            int actual = gameCube.HowManyThrowWas();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CanGetRanomResultFromGamecube() {
            GameCube gameCube = game.Cubes[0];
            for (int i = 0; i < 10; i++) {
                gameCube.PerformOneThrow();
                int result = gameCube.GetLastThrowResult();
                Console.WriteLine("wynik dla i = "+i+" wynosi: "+result);
                Assert.IsTrue(result>=1 && result<=6);
            }
        }

    }
}