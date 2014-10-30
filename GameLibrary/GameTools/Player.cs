using GameLibrary.Abstract;

namespace GameLibrary.GameTools {
    public class Player :IPlayer {
        private string _name;
        private int _score;
        public Player(string name, int score) {
            _name = name;
            _score = score;
        }
        public string Name {
            get { return _name; }
            set { _name = value; }
        }

        public int Score {
            get { return _score; }
            set { _score = value; }
        }
    }
}