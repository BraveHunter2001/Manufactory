using RawMaterialProducer.Entities;

namespace RawMaterialProducer.Services;

public interface IRawMaterialProducer
{
    public RawMaterialUnit ProduceUnit(RawMaterialType type, int mass);
}

public class RawMaterialProducer : IRawMaterialProducer
{
    public RawMaterialUnit ProduceUnit(RawMaterialType type, int mass) =>
        new() { Type = type, Mass = mass };
}