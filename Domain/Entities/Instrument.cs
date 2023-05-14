namespace Domain.Entities;

public class Instrument : AuditableEntity
{
    public string Name { get; set; }
    public string Code { get; set; }
    public string Dimensions { get; set; }
    public string Measure { get; set; }
    public decimal Price { get; set; }
    public byte[] Picture { get; set; }

    public InstrumentType InstrumentType { get; set; }
    public Gost Gost { get; set; }
}
