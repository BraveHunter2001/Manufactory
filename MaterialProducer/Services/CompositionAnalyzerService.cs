using MaterialProducer.DTOs;
using MaterialProducer.Entities;

namespace MaterialProducer.Services;

public interface ICompositionAnalyzerService
{
    public MaterialType AnalyzeRawMaterial(RawMaterialType rawMaterialType);
    public RawMaterialType AnalyzeMaterial(MaterialType materialType);
}

public class CompositionAnalyzerService : ICompositionAnalyzerService
{
    public MaterialType AnalyzeRawMaterial(RawMaterialType rawMaterialType) => rawMaterialType switch
    {
        RawMaterialType.Diamond => MaterialType.Diamond,
        RawMaterialType.Gold => MaterialType.Gold,
        _ => throw new NotImplementedException(),
    };

    public RawMaterialType AnalyzeMaterial(MaterialType materialType) => materialType switch
    {
        MaterialType.Diamond => RawMaterialType.Diamond,
        MaterialType.Gold => RawMaterialType.Gold,
        _ => throw new NotImplementedException(),
    };
}