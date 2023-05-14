namespace Domain.Entities;

public class InstrumentType : EntityBase
{
    public string Name { get; set; }

    public ICollection<Instrument> Instruments { get; set; }
}
