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

    [HttpGet]
    public ActionResult<IList<Character>> GetAllCharacters()
    {
      var results = db.Characters.ToList();
      return results;
    }

    [HttpGet("{id}")]
    public ActionResult<Character> GetSingleCharacter(int id)
    {
      var character = db.Characters.FirstOrDefault(c => c.Id == id);
      return character;
    }

    [HttpPost]
    public ActionResult<Character> AddCharacter([FromBody] Character characterToAdd)
    {
      db.Characters.Add(characterToAdd);
      db.SaveChanges();
      return characterToAdd;
    }

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

    [HttpDelete("{id}")]
    public ActionResult DeleteCharacter(int id)
    {
      var character = db.Characters.FirstOrDefault(c => c.Id == id);
      db.Characters.Remove(character);
      db.SaveChanges();
      return Ok();
    }

    [HttpDelete("name/{name}")]
    public ActionResult DeleteCharacterByName(string name)
    {
      var character = db.Characters.FirstOrDefault(c => c.Name.ToLower() == name.ToLower());
      db.Characters.Remove(character);
      db.SaveChanges();
      return Ok();
    }
  }
}
