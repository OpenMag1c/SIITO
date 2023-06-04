namespace Domain.Entities;

public class Instrument : AuditableEntity
{
    public string Name { get; set; } // наименование
    public string? Description { get; set; } // описание
    public string Measure { get; set; } // единицы измерения
    public decimal Price { get; set; } // цена
    public string Currency { get; set; } // валюта
    public byte[]? Picture { get; set; } // картинка

    public int InstrumentTypeId { get; set; }
    public InstrumentType InstrumentType { get; set; }
    public int GostId { get; set; }
    public Gost Gost { get; set; }
}
