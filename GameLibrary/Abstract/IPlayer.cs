using System;
using System.Collections;
using System.Collections.Generic;
using GameLibrary.Concrete;

namespace GameLibrary.Abstract {
    public interface IPlayer {
        String Name { get; set; }
        int Score { get; }
        IList<ThrowCubes> SetOfThrows { get;  }
    }
}