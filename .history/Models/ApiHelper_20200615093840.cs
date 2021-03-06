using System.Threading.Tasks;
using RestSharp;
using System;

namespace DeliverMeDeliveries.Models
{
  class ApiHelper
  {

      static void Main()
    {
      var apiCallTask = ApiHelper.ApiCall("[YOUR-API-KEY-HERE]");
      var result = apiCallTask.Result;
      Console.WriteLine(result);
    }


    public static async Task<string> ApiCall(string apiKey)
    {
      RestClient client = new RestClient("https://eatstreet.com/publicapi/v1/restaurant");
      RestRequest request = new RestRequest($"home.json?api-key={apiKey}", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }
  }
}

// P5LG4JN6VERBYZJRTPHAMLF75I======