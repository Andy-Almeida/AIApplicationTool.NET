using System;
using System.Threading.Tasks;
using RestSharp;
using Newtonsoft.Json.Linq;

public class ChatGPTClient
{
    private readonly string _apiKey;
    private readonly RestClient _client;

    public ChatGPTClient(string apiKey)
    {
        _apiKey = apiKey;
        _client = new RestClient("https://api.openai.com/v1/chat/completions");
    }

    public async Task<string> GetResponseAsync(string userInput)
    {
        var request = new RestRequest("",Method.Post);
        request.AddHeader("Authorization", $"Bearer {_apiKey}");
        request.AddHeader("Content-Type", "application/json");

        // Create JSON body for the request
        var body = new JObject
        {
            ["model"] = "gpt-3.5-turbo",
            ["messages"] = new JArray
            {
                new JObject
                {
                    ["role"] = "system",
                    ["content"] = "You are a helpful assistant."
                },
                new JObject
                {
                    ["role"] = "user",
                    ["content"] = userInput
                }
            }
        };
        request.AddJsonBody(body.ToString());

        // Execute the request
        var response = await _client.ExecuteAsync(request);
        if (response.IsSuccessful)
        {
            var jsonResponse = JObject.Parse(response.Content);
            var message = jsonResponse["choices"]?[0]?["message"]?["content"]?.ToString();
            return message ?? "No response from ChatGPT.";
        }
        else
        {
            throw new Exception($"Failed to get response: {response.Content}");
        }
    }
}