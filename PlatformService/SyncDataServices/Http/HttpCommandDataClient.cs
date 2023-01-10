using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using PlatformService.Dtos;

namespace PlatformService.SyncDataServices.Http
{
  public class HttpCommandDataClient : ICommandDataClient
  {
    private readonly IConfiguration _config;
    private readonly HttpClient _httpClient;

    public HttpCommandDataClient(HttpClient httpClient, IConfiguration config)
    {
      _config = config;
      _httpClient = httpClient;
    }


    public async Task SendPlatformToCommand(PlatformReadDto plat)
    {
      var httpContent = new StringContent(
        JsonSerializer.Serialize(plat),
        Encoding.UTF8,
        "application/json"
      );
      // Move uri to config file
      var response = await _httpClient.PostAsync(_config["CommandService"], httpContent); 
      if (response.IsSuccessStatusCode)
      {
        Console.WriteLine("--> Sync POST to Command Service was OK!");
      }
      else
      {
        Console.WriteLine("--> Sync POST to Command Service was NOT OK!");
      }
    }
  }
}