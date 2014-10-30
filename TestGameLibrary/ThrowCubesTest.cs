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
                Console.WriteLine("wynik dla kości o id: "+ gameCube.CubeGameID+" to : "+result);
            }
            Console.WriteLine("całkowity wynik wszystkich kości: "+totalThrowResult);
            int cubes = 5;
            int sides = 6;
            int maxResult = cubes*sides;
            int minResult = cubes*1;
            Assert.IsTrue(totalThrowResult > 0 && totalThrowResult <= maxResult);

        }

        [TestMethod]
        public void CanIGetThrowStoryForOneCube() {
            IGame game = new Game();
            var throwCubes = new ThrowCubes(game.Cubes); 
            //Throw three times
            throwCubes.PerformOneThrow();
            throwCubes.PerformOneThrow();
            throwCubes.PerformOneThrow();
            int score = 0;
            for (int i = 0; i < 3; i++) {
                int result = throwCubes.Cubes[0].ThrowHistory[i];
                score += result;
                Console.WriteLine("rzut numer: "+(i+1)+" wynosi: "+result);
            }
            Assert.IsTrue(score>=3 && score<=18);
        }

        [TestMethod]
        public void AllCubesCanThrowAfterStartGame() {
            IGame game = new Game();
            var throwCubes = new ThrowCubes(game.Cubes);
            bool isOk = throwCubes.Cubes.All(gameCube => gameCube.CanThrowNextTime());
            Assert.IsTrue(isOk);
        }

        [TestMethod]
        public void IfIWantICanThrowAllNextTime() {
            IGame game = new Game();
            var throwCubes = new ThrowCubes(game.Cubes);
            throwCubes.PerformOneThrow();
            bool isOk = throwCubes.Cubes.All(gameCube => gameCube.CanThrowNextTime());
            Assert.IsTrue(isOk);
        }
    
    }
}
