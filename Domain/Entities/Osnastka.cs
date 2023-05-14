namespace Domain.Entities;

public class Osnastka : AuditableEntity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public byte[] Picture { get; set; }

    public OsnastkaType OsnastkaType { get; set; }
}
