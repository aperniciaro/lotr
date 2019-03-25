using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using lotr.Models;
using Microsoft.AspNetCore.Mvc;

namespace lotr.Controllers
{
  [Route("api/[controller]")]
  [ApiController]

  public class RacesController : ControllerBase
  {
    private DatabaseContext db;
    public RacesController()
    {
      this.db = new DatabaseContext();
    }

    // GET api/values
    [HttpGet]
    public ActionResult<IList<Race>> GetAllRaces()
    {
      var results = db.Races.ToList();
      return results;
    }

    // GET api/values/5
    [HttpGet("{id}")]
    public ActionResult<Race> GetSingleRace(int id)
    {
      var race = db.Races.FirstOrDefault(r => r.Id == id);
      return race;
    }

    // POST api/values
    [HttpPost]
    public ActionResult<Race> AddRace([FromBody] Race raceToAdd)
    {
      db.Races.Add(raceToAdd);
      db.SaveChanges();
      return raceToAdd;
    }

    // PUT api/values/5
    [HttpPut("{id}")]
    public ActionResult<Race> UpdateRace(int id, [FromBody] Race newRaceData)
    {
      var race = db.Races.FirstOrDefault(r => r.Id == id);
      race.RaceName = newRaceData.RaceName;
      race.NativeLanguage = newRaceData.NativeLanguage;
      race.IsImmortal = newRaceData.IsImmortal;
      db.SaveChanges();
      return race;
    }

    // DELETE api/values/5
    [HttpDelete("{id}")]
    public ActionResult DeleteRace(int id)
    {
      var race = db.Races.FirstOrDefault(r => r.Id == id);
      db.Races.Remove(race);
      db.SaveChanges();
      return Ok();
    }
  }
}
