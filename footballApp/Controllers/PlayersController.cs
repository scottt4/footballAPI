using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FootballApp.Models;

namespace FootballApp.Controllers
{
    [Route("api/[controller]")]
    public class PlayersController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<Player> Get()
        {
            return new Player[]
            {
                new Player {Id =1,Name="Darelle Revis",Number=24,Position="CB"},
                new Player {Id =2,Name="Tom Brady",Number=12,Position="QB"},
                new Player {Id =3,Name="Peyton Manning",Number=18,Position="QB"},
            };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Player Get(int id)
        {
            return new Player { Id = 4, Name = "Chris Ivory", Number = 34, Position = "HB" };
        }

    }
}
