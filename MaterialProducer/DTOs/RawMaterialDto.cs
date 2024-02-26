namespace MaterialProducer.DTOs;


/// <summary>
/// TODO: полностью копирую свойства из модели RawMaterial. Можно ли этого как-то избежать?
/// </summary>
public class RawMaterialDto
{
    public RawMaterialType Type { get; set; }
    public int Mass { get; set; }
}

public enum RawMaterialType
{
    Diamond,
    Gold
}
