using System;
using System.Net.Http;
using Newtonsoft.Json;


namespace ProcessPreloaded
{
    public class Program
    {
        private static HttpClient _httpClient = new HttpClient();
        private static readonly string Url = @"";

        static void Main(string[] args)
        {
            ProcessPreloaded();
        }

        public static bool ProcessPreloaded()
        {
            _httpClient.Timeout = TimeSpan.FromDays(1);
            HttpResponseMessage result = _httpClient.GetAsync(Url).Result;
            if (result.StatusCode == System.Net.HttpStatusCode.OK)
                return true;
            string returnValue = result.Content.ReadAsStringAsync().Result;
            throw new Exception($"Failed to GET data: ({result.StatusCode}): {returnValue}");
        }
    }
}
