namespace RawMaterialProducer.Entities;

/// <summary>
/// Сырье 
/// </summary>
public class RawMaterialUnit
{
    public int Id { get; set; }
    public RawMaterialType Type { get; set; }
    public int Mass { get; set; }
}


/// <summary>
///  Тип сырья, из чего состоит 
/// </summary>
public enum RawMaterialType
{
    Diamond,
    Gold
}
