using System.Collections;
using System.Collections.Generic;
using GameLibrary.GameTools;

namespace GameLibrary.Abstract {
    public interface IGame {
        bool IsStarted { get; set; }
        IList<GameCube> Cubes { get; }
        IList<IPlayer> Players { get; }
        void MakeOneRound(IPlayer player);
    }
}