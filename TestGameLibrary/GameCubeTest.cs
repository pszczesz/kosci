using System;
using System.ComponentModel;
using GameLibrary.GameTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestGameLibrary
{
    [TestClass]
    public class GameCubeTest
    {
        [TestMethod]
        public void CanAddOneThrow()
        {
            GameCube gc = new GameCube(6);
            gc.PerformOneThrow();
            int actual = gc.HowManyThrowWas();
            int expepcted = 1;
            Assert.AreEqual(expepcted,actual);

        }

        [TestMethod]
        public void CanGetLastResult() {
            ICube cube = new Cube(6);
            GameCube gc = new GameCube(cube.HowMany);
            int expected = 3;
            gc.PerformOneThrow(expected);
            int last = gc.GetLastThrowResult();
            Assert.AreEqual(expected,last);
        }

        [TestMethod]
        public void CanGetCountThrows() {
           
            GameCube gameCube = new GameCube(6);
            gameCube.PerformOneThrow();
            gameCube.PerformOneThrow();
            gameCube.PerformOneThrow();
            int expected = 3;
            int actual = gameCube.HowManyThrowWas();
            Assert.AreEqual(expected,actual);
        }

        [TestMethod]
        public void CanGetWhenNoAnyThrow() {
            GameCube gameCube = new GameCube(6);
            int expected = 0;
            int actual = gameCube.HowManyThrowWas();
            Assert.AreEqual(expected,actual);
        }
    }
}
