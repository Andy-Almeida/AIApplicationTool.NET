using System;
using System.Threading.Tasks;
using RestSharp;
using Newtonsoft.Json.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Drawing.Text;
using System.Diagnostics;

class AskChatGPT
{
    public async Task Ask(string userInput)
    {
        var apiKey = Environment.GetEnvironmentVariable("OPENAI_API_KEY");
        if (apiKey == null)
        {
            return;
        }
        var chatClient = new ChatGPTClient(apiKey);

        try
        {
            var response = chatClient.GetResponseAsync(userInput);
            if (response == null)
            {
                return;
            }
            Debug.Print(response.ToString());
            return;
        }
        catch (Exception ex)
        {
            return;
        }
    }
}

        
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
        var body = BuildJSON(userInput); 
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

    public async Task<string> GetResponseAsync(string systemRole, string userInput)
    {
        var request = new RestRequest("",Method.Post);
        request.AddHeader("Authorization", $"Bearer {_apiKey}");
        request.AddHeader("Content-Type", "application/json");

        // Create JSON body for the request
        var body = BuildJSON(systemRole, userInput); 
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

    public JObject BuildJSON(string userInput)
    {
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
        return body;
    }
    
    public JObject BuildJSON(string systemRole, string userInput)
    {
        var body = new JObject
        {
            ["model"] = "gpt-3.5-turbo",
            ["messages"] = new JArray
            {
                new JObject
                {
                    ["role"] = "system",
                    ["content"] = systemRole
                },
                new JObject
                {
                    ["role"] = "user",
                    ["content"] = userInput
                }
            }
        };
        return body;
    }
}