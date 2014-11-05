using System.Collections.Generic;
using GameLibrary.Abstract;
using GameLibrary.Concrete;

namespace GameLibrary.GameTools {
    public class Player :IPlayer {
        private string _name;
        private int _score;
        private IList<ThrowCubes> _setOfThrows; 
        public Player(string name) {
            _name = name;
            _score = 0;
            _setOfThrows = new List<ThrowCubes>();

        }
        public string Name {
            get { return _name; }
            set { _name = value; }
        }

        public int Score {
            get { return _score; }
           // set { _score = value; }
        }

        public IList<ThrowCubes> SetOfThrows { get { return _setOfThrows; } }
    }
}