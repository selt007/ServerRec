using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Threading.Tasks;

internal class ChatGPTInit
{
    string apiKey = "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";
    private readonly HttpClient _httpClient;

    public ChatGPTInit()
    {
        _httpClient = new HttpClient();
        _httpClient.BaseAddress = new Uri("https://api.openai.com/v1/");
        _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiKey);
    }

    public async Task<string> SendPrompt(string prompt, string model)
    {
        var requestBody = new
        {
            prompt = prompt,
            model = model,
            max_tokens = 650,
            temperature = 0.9
        };

        var response = await _httpClient.PostAsJsonAsync("completions", requestBody);
        response.EnsureSuccessStatusCode();
        var responseBody = await response.Content.ReadAsStringAsync();
        var result = responseBody.Substring(responseBody.IndexOf("\"text\":\"")+8);
        result = result.Substring(0, result.IndexOf("\",\"index\":0,")).Replace("n","").Replace("\\","");

        return result;
    }
} 