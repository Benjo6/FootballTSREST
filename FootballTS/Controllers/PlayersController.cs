using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lib;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace REST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayersController : ControllerBase
    {
        private static readonly List<Player> players = new List<Player>
        {
            new Player {Id=1,Name="De Bruyne", Position="AM", Team="Manchester City",Value=120 },
            new Player {Id=2,Name="Mbappe", Position="CF", Team="PSG",Value=180 },
            new Player {Id=3,Name="Sterling", Position="LW", Team="Manchester City",Value=128 },
            new Player {Id=4,Name="Neymar", Position="LW", Team="PSG",Value=128 },
            new Player {Id=5,Name="Mane", Position="LW", Team="Liverpool",Value=120 },
            new Player {Id=6,Name="Kane", Position="CF", Team="Tottenham",Value=120 },
            new Player {Id=7,Name="Sancho", Position="RW", Team="Dortmund",Value=117 },
            new Player {Id=8,Name="Messi", Position="RW", Team="Barcelona",Value=112 },
            new Player {Id=9,Name="Alexander-Arnold", Position="RB", Team="Liverpool",Value=110 },
            new Player {Id=10,Name="Griezmann", Position="CF", Team="Barcelona",Value=96 },
            new Player {Id=11,Name="Gnabry", Position="RW", Team="Bayern Munich",Value=90 },
            new Player {Id=12,Name="Kimmich", Position="DM", Team="Bayern Munich",Value=85 },
            new Player {Id=13,Name="Lukaku", Position="CF", Team="Inter Milan",Value=85 },
            new Player {Id=14,Name="Joao Felix", Position="SS", Team="Atletico Madrid",Value=81 },
            new Player {Id=15,Name="Havertz", Position="AM", Team="Chelsea",Value=81 },
            new Player {Id=16,Name="Davies", Position="LB", Team="Bayern Munich",Value=80 },
            new Player {Id=17,Name="Haaland", Position="CF", Team="Dortmund",Value=80 },
            new Player {Id=18,Name="Rashford", Position="LW", Team="Manchester United",Value=80 },

        };
        private static int _nextId = 19;
        // GET: api/<PlayersController>
        [HttpGet]
        public IEnumerable<Player> Get()
        {
            return players;
        
        }

        // GET api/<PlayersController>/5
        [HttpGet("{id}")]
        public Player Get(int id)
        {
            return players.Find(p => p.Id == id);
      
        }

        // POST api/<PlayersController>
        [HttpPost]
        public void Post([FromBody] Player value)
        {
            players.Add(value);
        }

        // PUT api/<PlayersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Player value)
        {
            Player p = Get(id);
            if(p!= null)
            {
                p.Id = value.Id;
                p.Name = value.Name;
                p.Position = value.Position;
                p.Team = value.Team;
                p.Value = p.Value;
            }
        }

        // DELETE api/<PlayersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Player p = Get(id);
            if (p != null)
            {
                players.Remove(p);
            }
        }
    }
}
