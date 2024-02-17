using MaterialProducer.DTOs;
using RestSharp;

namespace MaterialProducer.Consumers;

public interface IRawMaterialConsumer
{
    RawMaterialDto Consume(RawMaterialType type, int mass);
}

public class RawMaterialConsumer : IRawMaterialConsumer
{
    private const string _rawMaterialProducerUrl = "http://localhost:5118/api";
    private static readonly RestClientOptions _options = new(_rawMaterialProducerUrl);

    public RawMaterialDto Consume(RawMaterialType type, int mass)
    {
        var client = new RestClient(_options);
        var request = new RestRequest("rawMaterial/produceUnit").AddJsonBody(new { Type = type, Mass = mass });

        var response = client.Get<RawMaterialDto>(request);
        return response;
    }
}