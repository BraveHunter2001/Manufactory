using MaterialProducer.DTOs;
using MaterialProducer.Entities;

namespace MaterialProducer.Services;

public interface IMaterialProducer
{
    public Material Produce(RawMaterialDto rawMaterial);
}

public class MaterialProducer(ICompositionAnalyzerService compositionAnalyzerService) : IMaterialProducer
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
}