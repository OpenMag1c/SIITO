namespace Domain.Entities;

public class Gost : AuditableEntity
{
    public string Name { get; set; }
    public string Link { get; set; }

    public ICollection<Instrument> Instruments { get; set; }
}
