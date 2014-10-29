using System.Collections.Generic;
using System.Linq;
using GameLibrary.Abstract;
using GameLibrary.GameTools;

namespace GameLibrary.Concrete {
    public class ThrowCubes :IThrow{
        public ThrowCubes(IList<GameCube> cubes ) {
            this.cubes = cubes;
        }
        private IList<GameCube> cubes;

        public IList<GameCube> Cubes {
            get { return cubes; }
        }

        public void PerformOneThrow(int how=-1) {
            foreach (var gameCube in Cubes) {
                if (gameCube.CanThrowNextTime()) {
                    gameCube.PerformOneThrow(how);
                }
                else {
                    gameCube.CanThrowCube = false;
                }
            }
        }

        public int GetLastThrowScore() {
            throw new System.NotImplementedException();
        }
    }
}