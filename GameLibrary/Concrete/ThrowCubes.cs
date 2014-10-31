using System.Collections.Generic;
using System.Linq;
using GameLibrary.Abstract;
using GameLibrary.GameTools;

namespace GameLibrary.Concrete {
    public class ThrowCubes :IThrow {
        public const int CUBE_DONT_THROW_SCORE = -99;
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
                    gameCube.PerformOneThrow(CUBE_DONT_THROW_SCORE);
                    gameCube.CanThrowCube = false;
                }
            }
        }

        public int GetLastThrowScore() {
            return Cubes.Where(gc => gc.GetLastThrowResult() != CUBE_DONT_THROW_SCORE).Sum(gc => gc.GetLastThrowResult());
        }

        public IList<ThrowResults> GetLastScoreForAllCubes() {
            return  Cubes.Select(gameCube => new ThrowResults()
                {CubeID = gameCube.CubeGameID, ThrowResult = gameCube.GetLastThrowResult()}).ToList();
        } 
    }
}