namespace Domain.Entities;

public class OsnastkaType : EntityBase
{
    public string Name { get; set; }

    public ICollection<Osnastka> Osnastkas { get; set; }
}
