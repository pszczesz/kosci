using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GameLibrary.Abstract;
using GameLibrary.GameTools;
using GraWKosciWebInterface.Models.Concrete;

namespace GraWKosciWebInterface.Controllers
{
    public class HomeController : Controller
    {
        
        private WebGame game;
        private IList<IPlayer> players;
        public HomeController() {
            players = new List<IPlayer>();
            players.Add(new Player("test1"));
            game = new WebGame(players);
        }
        // GET: Home
        public ActionResult Index()
        {
            game.Game.MakeOneRound(players[0]);
            return View(game);
        }
    }
}