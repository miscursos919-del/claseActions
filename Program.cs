using System;
using System.Net.Http;
using System.Threading.Tasks;

class Program
{
  static async Task Main(string[] args)
  {
    string apiKey = Environment.GetEnvironmentVariable("OPENWEATHERMAP_APIKEY");
    string ciudad = "Amsterdam";
    string url = $"https://api.openweathermap.org/data/2.5/weather?q={ciudad}&appid={apiKey}&units=metric";

    using HttpClient client = new HttpClient();
    var response = await client.GetAsync(url);
    var content = await response.Content.ReadAsStringAsync();

    Console.WriteLine($"Clima Actual en {ciudad}:");
    Console.WriteLine(content);
  }
}
