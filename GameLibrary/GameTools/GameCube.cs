using System.Collections.Generic;
using System.Linq;

namespace GameLibrary.GameTools {
    public class GameCube {
        public IList<int> ThrowHistory { get; private set; }
        private ICube _cube;
        public bool CanThrowCube { get; set; }

        public GameCube(int howMany) {
            ThrowHistory = new List<int>();
            _cube =  new Cube(howMany);
        }

        public int HowManyThrowWas() {
            return ThrowHistory != null ? ThrowHistory.Count : -1;
        }

        public void PerformOneThrow(int how=-1) {
            int resultThrow = _cube.GetResult(how);
            ThrowHistory.Add(resultThrow);
        }

        public int GetLastThrowResult() {
            return ThrowHistory.Last();
        }
    }
}