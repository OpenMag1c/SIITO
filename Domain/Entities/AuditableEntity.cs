namespace Domain.Entities;

public class AuditableEntity : EntityBase
{
    public DateTime? CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }

}
