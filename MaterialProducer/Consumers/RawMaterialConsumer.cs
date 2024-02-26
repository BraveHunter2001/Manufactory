using Core;
using MaterialProducer.DTOs;

namespace MaterialProducer.Consumers;

public interface IRawMaterialConsumer
{
    RawMaterialDto Consume(RawMaterialType type, int mass);
}

public class RawMaterialConsumer : Consumer, IRawMaterialConsumer
{
    public override string ConsumerURL => "http://localhost:5118/api";
    private const string _processedUnit = "rawMaterial/produceUnit";

    public RawMaterialDto Consume(RawMaterialType type, int mass)
    {
        var response = SendRequestAsync<RawMaterialDto, RawMaterialDto>(new() { Type = type, Mass = mass }, _processedUnit).Result;
        return response;
    }
}