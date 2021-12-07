using System;
using System.Text;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
public static class Helper
{
    private static string token = "7dbad156232a6be65949e1263f4afb134ce4fc9d";
    public async static Task<string> GetVariable(string deviceID, string var) {
        string url = "https://api.particle.io/v1/devices/" + deviceID + "/" + var + "?access_token=" + token;
        using (var client = new HttpClient()){
            var result = await client.GetStringAsync(url);
            var res = JObject.Parse(result);
            return (string)res["result"];
        }
    }

    public async static Task<int> callFunction(string deviceID, string func, string argument)
    {
        string url = "https://api.particle.io/v1/devices/" + deviceID + "/" + func;
        Console.WriteLine(url);
        var Data = new {arg = argument};

        var json_data = JsonConvert.SerializeObject(Data);
        var payload = new StringContent(json_data, Encoding.UTF8, "application/json");

        using (var client = new HttpClient())
        {
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            var result = await client.PostAsync(url, payload);
            var deserialized_res = result.Content.ReadAsStringAsync().Result;
            var res = JObject.Parse(deserialized_res);
            return (int)res["return_value"];
        }
    }

}