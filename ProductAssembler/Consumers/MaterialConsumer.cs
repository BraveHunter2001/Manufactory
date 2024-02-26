using Core;
using ProductAssembler.DTO;

namespace ProductAssembler.Consumers;

public interface IMaterialConsumer
{
    Material Consume(MaterialType type, int mass);
}

public class MaterialConsumer : Consumer, IMaterialConsumer
{
    public override string ConsumerURL => "http://localhost:5219/api";
    private const string _processedUnit = "material/produceUnit";
    public Material Consume(MaterialType type, int mass) => SendRequestAsync<MaterialRequestDTO, Material>(new() { Type = type, Mass = mass }, _processedUnit).Result;
}