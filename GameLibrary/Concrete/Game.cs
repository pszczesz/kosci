using System.Collections.Generic;
using GameLibrary.Abstract;
using GameLibrary.GameTools;

namespace GameLibrary.Concrete {
    public class Game:IGame {
        public Game(IList<GameCube> cubes) {
            _cubes = cubes;
        }

        public Game(int cubes = 5, int sides = 6) {
            _cubes = new List<GameCube>();
            for (int i = 0; i < cubes; i++) {
                _cubes.Add(new GameCube(sides));
            }
        }
       
        private IList<GameCube> _cubes;
        public bool IsStarted { get; set; }

        public IList<GameCube> Cubes {
            get { return _cubes; }
        }

    }
}