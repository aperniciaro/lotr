namespace lotr.ViewModels
{
  public class CharacterViewModel
  {
    public int Id { get; set; }

    public string Name { get; set; }

    public string WeaponOfChoice { get; set; }

    public string Profession { get; set; }

    public string Residence { get; set; }

    public bool HasWieldedOneRing { get; set; }

    public int? RaceId { get; set; }

    public string RaceName { get; set; }
  }
}