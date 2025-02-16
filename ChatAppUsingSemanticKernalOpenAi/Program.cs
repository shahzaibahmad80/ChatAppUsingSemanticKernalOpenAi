using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
class Program
{
    static readonly HttpClient client = new HttpClient();

    static async Task Main()
    {
        Console.WriteLine("Ollama AI Chatbot (Type 'exit' to quit)");

        while (true)
        {
            Console.Write("User >> ");
            string userMessage = Console.ReadLine();

            if (userMessage.ToLower() == "exit")
                break;

            string aiResponse = await SendToOllama(userMessage);
            Console.WriteLine("AI >> " + aiResponse);
        }
    }

    static async Task<string> SendToOllama(string prompt)
    {
        string ollamaUrl = "http://localhost:11434/api/generate";

        var requestBody = new
        {
            model = "deepseek-r1:1.5b",  // Model name 
            prompt = prompt,
            stream = false // we Streaming enable  'true' if we want the response in chunks/word by word by like typing like human
        };

        string jsonContent = JsonSerializer.Serialize(requestBody);
        var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

        HttpResponseMessage response = await client.PostAsync(ollamaUrl, content);

        if (!response.IsSuccessStatusCode)
        {
            return $"Error: {response.StatusCode}";
        }

        string responseBody = await response.Content.ReadAsStringAsync();
        using JsonDocument doc = JsonDocument.Parse(responseBody);
        return doc.RootElement.GetProperty("response").GetString();
    }
}
