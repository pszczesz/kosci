using System;
using System.Collections.Generic;
using GameLibrary.Abstract;
using GameLibrary.GameTools;

namespace GameLibrary.Concrete {
    public class Game : IGame {
        private Random random;
        private IList<ThrowCubes> _gameRounds;

        public Game() {
            GameSetUp gameSetUp = new GameSetUp(null);
            random = gameSetUp.GetRandom();
            SetCubeGame();
            _gameRounds = new List<ThrowCubes>();
        }

        public Game(IList<IPlayer> players, int cubesSide, int cubesCount) {
            GameSetUp gameSetUp = new GameSetUp(players, cubesSide, cubesCount);
            random = gameSetUp.GetRandom();
            SetCubeGame(cubesSide,cubesCount);
            _gameRounds = new List<ThrowCubes>();
        }

        public void MakeOneRound(IPlayer player) {
            ThrowCubes throwCubes = new ThrowCubes(_cubes);
            _gameRounds.Add(throwCubes);
            player.SetOfThrows.Add(throwCubes);
            throwCubes.PerformOneThrow();

        }
        private void SetCubeGame(int cubeSide = 6, int cubeCount = 5) {
            _cubes = new List<GameCube>();
            for (int i = 0; i < cubeCount; i++) {
                _cubes.Add(new GameCube(new Cube(cubeSide,random)));
            }
        }
        private IList<GameCube> _cubes;
        public bool IsStarted { get; set; }

        public IList<GameCube> Cubes => _cubes;
    }
}