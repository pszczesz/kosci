using System;
using System.Collections.Generic;
using System.Linq;

namespace GameLibrary.GameTools {
    public class GameCube {
        public IList<int> ThrowHistory { get; private set; }
        private ICube _cube;
        private static int licznik = 0;
        private int _cubeGameID;
        public bool CanThrowCube { get; set; }

        public GameCube(ICube cube) {
            ThrowHistory = new List<int>();
            if(cube==null) throw new ArgumentNullException("Nie zainicjowano Cube");
            _cube = cube;
            _cubeGameID = ++ licznik;
        }

        public int HowManyThrowWas() {
            return ThrowHistory != null ? ThrowHistory.Count : -1;
        }

        public void PerformOneThrow(int how=-1) {
            int resultThrow = _cube.GetResult(how);
           // Console.WriteLine("wylosowano: "+resultThrow);
            ThrowHistory.Add(resultThrow);
        }
        public int CubeGameID { get { return _cubeGameID; } }
        public int GetLastThrowResult() {
            return ThrowHistory.Last();
        }
        public ICube Cube { get { return _cube; } }
    }
}