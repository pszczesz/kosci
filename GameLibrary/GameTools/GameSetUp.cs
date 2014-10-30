using System;
using System.Collections;
using System.Collections.Generic;
using GameLibrary.Abstract;

namespace GameLibrary.GameTools {
    public class GameSetUp {
        private const int StandardCubeCount = 5;
        private const int StandardCubeSide = 6;
        private readonly Random _random; 

        private IList<IPlayer> _players;
        private int _cubeSide;
        private int _cubeCount;
        public GameSetUp(IList<IPlayer> players, int cubeSide=StandardCubeSide, int cubeCount=StandardCubeCount) {
            _players = players ?? new List<IPlayer>(){new Player("Standard",0)};
            _cubeSide = cubeSide;
            _cubeCount = cubeCount;
            _random = new Random();
        }

        public Random GetRandom() {
            return _random;
        }
    }
}