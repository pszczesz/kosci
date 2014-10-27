using System;
using System.Collections.Generic;
using GameLibrary.Abstract;
using GameLibrary.GameTools;

namespace GameLibrary.Concrete {
    public class Game : IGame {
        private Random random;

        public Game() {
            GameSetUp gameSetUp = new GameSetUp(null);
            random = gameSetUp.GetRandom();
            SetCubeGame();
        }

        public Game(IList<IPlayer> players, int cubesSide, int cubesCount) {
            GameSetUp gameSetUp = new GameSetUp(players, cubesSide, cubesCount);
            random = gameSetUp.GetRandom();
            SetCubeGame(cubesSide,cubesCount);
        }

        private void SetCubeGame(int cubeSide = 6, int cubeCount = 5) {
            _cubes = new List<GameCube>();
            for (int i = 0; i < cubeCount; i++) {
                _cubes.Add(new GameCube(new Cube(cubeSide,random)));
            }
        }
        private IList<GameCube> _cubes;
        public bool IsStarted { get; set; }

        public IList<GameCube> Cubes {
            get { return _cubes; }
        }
    }
}