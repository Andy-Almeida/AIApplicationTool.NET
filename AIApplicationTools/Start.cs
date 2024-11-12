using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        var apiKey = Environment.GetEnvironmentVariable("OPENAI_API_KEY");
        var chatClient = new ChatGPTClient(apiKey);

        Console.WriteLine("Enter a question for ChatGPT:");
        string userInput = Console.ReadLine();

        try
        {
            var response = await chatClient.GetResponseAsync(userInput);
            Console.WriteLine("ChatGPT Response: " + response);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
