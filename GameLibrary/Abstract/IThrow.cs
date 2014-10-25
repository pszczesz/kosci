using System.Collections.Generic;
using GameLibrary.GameTools;

namespace GameLibrary.Abstract {
    public interface IThrow {
        IList<GameCube> Cubes { get;  }
        void PerformOneThrow(int how=-1);
        int GetLastThrowScore();
    }
}