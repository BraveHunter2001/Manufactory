using RestSharp;

namespace Core;

public abstract class Consumer
{
    public virtual string ConsumerURL { get; }

    public async Task<TResponse> SendRequestAsync<TRequest, TResponse>(TRequest requestBody, string method, HttpMethodType type = HttpMethodType.Get) where TRequest : class
    {
        var client = new RestClient(new RestClientOptions(ConsumerURL));
        var request = new RestRequest(method).AddJsonBody(requestBody);
        var response = type switch
        {
            HttpMethodType.Post => await client.PostAsync<TResponse>(request),
            _ => await client.GetAsync<TResponse>(request),
        };

        return response;
    }
}

public enum HttpMethodType
{
    Get,
    Post
}