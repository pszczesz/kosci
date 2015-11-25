using System;
using System.Collections.Generic;
using System.Linq;
using GameLibrary.Abstract;
using GameLibrary.Concrete;
using GameLibrary.GameTools;

namespace GraWKosciWebInterface.Models.Concrete {
    public class WebGame {
        public IGame Game { get; set; }
        public IList<IPlayer> Players { get; set; } 
        public WebGame(IList<IPlayer> players ) {
            if (players == null) throw new ArgumentNullException("Brak graczy");
                Players = players;
                Game = new Game(players, 6, 5);
           
        }

    }
}