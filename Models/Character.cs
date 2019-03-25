namespace lotr.Models
{
  public class Character
  {
    public int Id { get; set; }

    public string Name { get; set; }

    public string WeaponOfChoice { get; set; }

    public string Profession { get; set; }

    public string Residence { get; set; }

    public bool HasWieldedOneRing { get; set; }

    public int? RaceId { get; set; }

    public Race Race { get; set; }
  }
}