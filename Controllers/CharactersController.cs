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

  public class CharactersController : ControllerBase
  {
    private DatabaseContext db;
    public CharactersController()
    {
      this.db = new DatabaseContext();
    }

    // GET api/values
    [HttpGet]
    public ActionResult<IList<Character>> GetAllCharacters()
    {
      var results = db.Characters.ToList();
      return results;
    }

    // GET api/values/5
    [HttpGet("{id}")]
    public ActionResult<Character> GetSingleCharacter(int id)
    {
      var character = db.Characters.FirstOrDefault(c => c.Id == id);
      return character;
    }

    // POST api/values
    [HttpPost]
    public ActionResult<Character> AddCharacter([FromBody] Character characterToAdd)
    {
      db.Characters.Add(characterToAdd);
      db.SaveChanges();
      return characterToAdd;
    }

    // PUT api/values/5
    [HttpPut("{id}")]
    public ActionResult<Character> UpdateCharacter(int id, [FromBody] Character newCharacterData)
    {
      var character = db.Characters.FirstOrDefault(c => c.Id == id);
      character.Name = newCharacterData.Name;
      character.WeaponOfChoice = newCharacterData.WeaponOfChoice;
      character.Profession = newCharacterData.Profession;
      character.Residence = newCharacterData.Residence;
      character.HasWieldedOneRing = newCharacterData.HasWieldedOneRing;
      character.RaceId = newCharacterData.RaceId;
      db.SaveChanges();
      return character;
    }

    // DELETE api/values/5
    [HttpDelete("{id}")]
    public ActionResult DeleteCharacter(int id)
    {
      var character = db.Characters.FirstOrDefault(c => c.Id == id);
      db.Characters.Remove(character);
      db.SaveChanges();
      return Ok();
    }
  }
}
