using System;
using System.Collections;
using System.Collections.Generic;
using GameLibrary.Abstract;
using GameLibrary.Concrete;
using GameLibrary.GameTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestGameLibrary {
    [TestClass]
    public class GameTest {
        [TestMethod]
        public void CanSetStandardPlayer() {
            IGame newGame = new Game();
            IPlayer player = newGame.Players[0];
            string expectedName = "Standard";
            Assert.AreEqual(expectedName, player.Name);
        }

        [TestMethod]
        public void CanSetPlayersList() {
            IList<IPlayer> players = new List<IPlayer>() {
                                                             new Player("pierwszy"),
                                                             new Player("drugi"),
                                                             new Player("trzeci")
                                                         };
            IGame newGame = new Game(players);
            Assert.AreEqual(3, newGame.Players.Count);
            Assert.AreEqual("drugi", newGame.Players[1].Name);
        }

        [TestMethod]
        public void CanThrowCubesForPlayer() {
            IList<IPlayer> players = new List<IPlayer>() {
                                                             new Player("pierwszy"),
                                                             new Player("drugi"),
                                                             new Player("trzeci")
                                                         };
            IGame newGame = new Game(players);
            newGame.MakeOneRound(newGame.Players[0]);
            IList<ThrowResults> resultses = newGame.Players[0].SetOfThrows[0].GetLastScoreForAllCubes();
            foreach (var throwResultse in resultses) {
                Console.WriteLine("kostka o id: " + throwResultse.CubeID
                                  + " dała resultat " + throwResultse.ThrowResult);
            }
            Console.WriteLine("Historia rzutów kostek");
            foreach (var gameCube in newGame.Cubes) {
                Console.WriteLine("\tDla kostki o id: " + gameCube.CubeGameID);
                foreach (var i in gameCube.ThrowHistory) {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
            Assert.IsTrue(players[0].SetOfThrows.Count > 0);
        }

        [TestMethod]
        public void CanThrowCubesSomeTimes() {
            IList<IPlayer> players = new List<IPlayer>() {
                                                             new Player("pierwszy"),
                                                             new Player("drugi"),
                                                             new Player("trzeci")
                                                         };
            IGame newGame = new Game(players);
            for (int i = 0; i < 3; i++) {
                newGame.MakeOneRound(newGame.Players[0]);
            }

            IList<ThrowResults> resultses = newGame.Players[0].SetOfThrows[0].GetLastScoreForAllCubes();
            foreach (var throwResultse in resultses) {
                Console.WriteLine("kostka o id: " + throwResultse.CubeID
                                  + " dała resultat " + throwResultse.ThrowResult);
            }
            Console.WriteLine("Historia rzutów kostek");
            foreach (var gameCube in newGame.Cubes) {
                Console.WriteLine("\tDla kostki o id: " + gameCube.CubeGameID);
                foreach (var i in gameCube.ThrowHistory) {
                    Console.Write("\t\t" + i + " ");
                }
                Console.WriteLine();
            }
            Assert.IsTrue(players[0].SetOfThrows.Count == 3);
        }

        [TestMethod]
        public void CanThrowSomeCubesSomeTimes() {
            IList<IPlayer> players = new List<IPlayer>() {
                                                             new Player("pierwszy"),
                                                             new Player("drugi"),
                                                             new Player("trzeci")
                                                         };
            IGame newGame = new Game(players);
            newGame.MakeOneRound(newGame.Players[0]);
            //next round only cube 1,2,3 throw
            newGame.Cubes[0].CanThrowCube = false;
            newGame.Cubes[4].CanThrowCube = false;
            
            newGame.MakeOneRound(newGame.Players[0]);
            //next round only cube 1,2
            newGame.Cubes[3].CanThrowCube = false;
            newGame.MakeOneRound(newGame.Players[0]);
            IList<ThrowResults> resultses = newGame.Players[0].SetOfThrows[0].GetLastScoreForAllCubes();
            foreach (var throwResultse in resultses) {
                Console.WriteLine("kostka o id: " + throwResultse.CubeID
                                  + " dała resultat " + throwResultse.ThrowResult);
            }
            Console.WriteLine("Historia rzutów kostek");
            foreach (var gameCube in newGame.Cubes) {
                Console.WriteLine("\tDla kostki o id: " + gameCube.CubeGameID);
                foreach (var i in gameCube.ThrowHistory) {
                    Console.Write("\t\t" + i + " ");
                }
                Console.WriteLine();
            }
            Assert.IsTrue(players[0].SetOfThrows.Count == 3);
        }
    }
}