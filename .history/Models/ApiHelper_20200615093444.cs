using System.Threading.Tasks;
using RestSharp;

namespace DeliverMeDeliveries.Models
{
  class ApiHelper
  {
    public static async Task<string> GetAll(string apiKey)
    {
      RestClient client = new RestClient("https://eatstreet.com/publicapi/v1/restaurant");
      RestRequest request = new RestRequest($"home", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }
  }
}