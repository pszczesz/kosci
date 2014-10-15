using GameLibrary.Abstract;

namespace GameLibrary.Concrete {
    public class GameLauncher {
        public static IGame StartNewGame() {
            IGame game = new Game();
            game.IsStarted = true;
            return game;
        }

        public static void StopTheGame(IGame game) {
            game.IsStarted = false;
        }
    }
}