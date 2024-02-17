using RawMaterialProducer.Entities;

namespace RawMaterialProducer.Models;

public class RawMaterialUnitViewModel(RawMaterialUnit unit)
{
    public string Type { get; set; } = unit.Type.ToString();
    public int Mass { get; set; } = unit.Mass;
}
