namespace Entites.RawMaterials;

/// <summary>
/// Сырье 
/// </summary>
public class RawMaterial
{
    public RawMaterialType Type { get; set; }
    public int Mass { get; set; }
}


/// <summary>
///  Тип сырья, из чего состоит 
/// </summary>
public enum RawMaterialType
{
    Diamond
}
