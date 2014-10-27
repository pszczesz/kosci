using System;
using System.Linq;
using GameLibrary.Abstract;
using GameLibrary.Concrete;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestGameLibrary
{
    [TestClass]
    public class ThrowCubesTest
    {
        [TestMethod]
        public void CanIGetResultForLastThrow()
        {
            IGame game = new Game();
            var throwCubes = new ThrowCubes(game.Cubes);
            int result = 3;
            throwCubes.PerformOneThrow(result);
            int totalThrowResult = 0;
            foreach (var gameCube in throwCubes.Cubes) {
                totalThrowResult += gameCube.GetLastThrowResult();
                Console.WriteLine(totalThrowResult);
            }
             int cubes = 5;
            
             int expected = cubes*result;
            Assert.AreEqual(expected,totalThrowResult);
        }

        [TestMethod]
        public void CanIGetRandomResult() {
            IGame game = new Game();
            var throwCubes = new ThrowCubes(game.Cubes);
            throwCubes.PerformOneThrow();
            int totalThrowResult = 0;
            foreach (var gameCube in throwCubes.Cubes) {
                int result = gameCube.GetLastThrowResult();
                totalThrowResult += result;
                Console.WriteLine("wynik: "+result);
            }
            Console.WriteLine("wynik: "+totalThrowResult);
            int cubes = 5;
            int sides = 6;
            int maxResult = cubes*sides;
            int minResult = cubes*1;
            Assert.IsTrue(totalThrowResult > 0 && totalThrowResult <= maxResult);

        }
    }
}
