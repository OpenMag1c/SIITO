namespace Domain.Entities;

public class Instrument : AuditableEntity
{
    public string Name { get; set; } // наименование
    public string Code { get; set; } // шифр
    public string Dimensions { get; set; } // размер
    public string Measure { get; set; } // единицы измерения
    public decimal Price { get; set; } // цена
    public byte[] Picture { get; set; } // картинка

    public InstrumentType InstrumentType { get; set; }
    public Gost Gost { get; set; }
}
