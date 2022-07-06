using CoreWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CoreWebApp.Controllers
{
    public class PlayersController : Controller
    {
        public IActionResult Index()
        {
            List<Player> listPlayers = new List<Player>
            {
                new Player { PId=1,PName="MSD",PTeam="CSK",PAvg=65.89},
                new Player { PId=2,PName="Rohit",PTeam="MI",PAvg=73.45},
                new Player { PId=4,PName="Virat",PTeam="RCB",PAvg=78.56},
                new Player { PId=3,PName="Vijay",PTeam="CSK",PAvg=70.26}

            };

            return View(listPlayers);
        }
    }
}
