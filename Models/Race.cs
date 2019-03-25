using System.Collections.Generic;

namespace lotr.Models
{
  public class Race
  {
    public int Id { get; set; }

    public string RaceName { get; set; }

    public string NativeLanguage { get; set; }

    public bool IsImmortal { get; set; }

    public List<Character> Characters { get; set; } = new List<Character>();
  }
}