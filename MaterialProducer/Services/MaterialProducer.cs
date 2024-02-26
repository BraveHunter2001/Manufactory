using MaterialProducer.Consumers;
using MaterialProducer.DTOs;
using MaterialProducer.Entities;

namespace MaterialProducer.Services;

public interface IMaterialProducer
{
    public Material Produce(RawMaterialDto rawMaterial);
    public Material Produce(MaterialRequestDTO material);
}

public class MaterialProducer(ICompositionAnalyzerService compositionAnalyzerService, IRawMaterialConsumer rawMaterialConsumer) : IMaterialProducer
{
    public Material Produce(RawMaterialDto rawMaterial)
    {
        var material = new Material
        {
            Type = compositionAnalyzerService.AnalyzeRawMaterial(rawMaterial.Type),
            Mass = rawMaterial.Mass,
            Quality = Utils.Utils.RandomEnumValue<Quality>()
        };

        return material;
    }

    public Material Produce(MaterialRequestDTO material)
    {
        var rawMaterialType = compositionAnalyzerService.AnalyzeMaterial(material.Type);
        var rawMaterial = rawMaterialConsumer.Consume(rawMaterialType, material.Mass);

        return new()
        {
            Type = material.Type,
            Mass = rawMaterial.Mass,
            Quality = Utils.Utils.RandomEnumValue<Quality>()
        };
    }
}