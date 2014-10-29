using System;

namespace GameLibrary.Abstract {
    public interface IPlayer {
        String Name { get; set; }
        int Score { get; set; }
    }
}