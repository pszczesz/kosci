using System.Collections.Generic;
using GameLibrary.Abstract;
using GameLibrary.GameTools;

namespace GameLibrary.Concrete {
    public class ThrowCubes :IThrow{
        public ThrowCubes() {
            _lastThrow = new List<GameCube>();
        }
        private IList<GameCube> _lastThrow;

        public IList<GameCube> LastThrow {
            get { return _lastThrow; }
        }

        public void PerformOneThrow(IList<GameCube> gameCubes) {
            throw new System.NotImplementedException();
        }

        public int GetLastThrowScore() {
            throw new System.NotImplementedException();
        }
    }
}