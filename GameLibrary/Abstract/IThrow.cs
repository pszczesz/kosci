using System.Collections.Generic;
using GameLibrary.GameTools;

namespace GameLibrary.Abstract {
    public interface IThrow {
        IList<GameCube> LastThrow { get;  }
        void PerformOneThrow(IList<GameCube> gameCubes);
    }
}