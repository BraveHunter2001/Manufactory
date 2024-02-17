using MaterialProducer.DTOs;
using MaterialProducer.Entities;

namespace MaterialProducer.Services;

public interface ICompositionAnalyzerService
{
    public MaterialType AnalyzeRawMaterial(RawMaterialType rawMaterialType);
}

public class CompositionAnalyzerService : ICompositionAnalyzerService
{
    public MaterialType AnalyzeRawMaterial(RawMaterialType rawMaterialType) => rawMaterialType switch
    {
        RawMaterialType.Diamond => MaterialType.Diamond,
        _ => throw new NotImplementedException(),
    };
}