using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace ClgProject.Controllers
{

    public static class RestApiClient
    {
        // In my case this is https://localhost:44366/
        // private static readonly string apiBasicUri = "http://172.16.3.18:3000/";
        //http://172.16.3.55:3000/
        // private static readonly string apiBasicUri = "https://dog.ceo/api/breeds/image/random";
       // private static readonly string apiBasicUri = "https://reqbin.com/echo/post/json";
        private static readonly string apiBasicUri = "http://172.16.3.55:3000/";
        public static async Task<G> Post<T,G>(string url, T contentValue) 
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiBasicUri);
                //client.DefaultRequestHeaders.Add("Authorization", "Bearer token");
                var content = new StringContent(JsonConvert.SerializeObject(contentValue), Encoding.UTF8, "application/json");
                string urrll =   apiBasicUri + url;
                var result = await client.PostAsync(urrll, content);
                result.EnsureSuccessStatusCode(); 
                string resultContentString = await result.Content.ReadAsStringAsync();
                
                G resultContent = JsonConvert.DeserializeObject<G>(resultContentString);
                return resultContent;
            }
        }

        public static async Task Put<T>(string url, T stringValue)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiBasicUri);
                var content = new StringContent(JsonConvert.SerializeObject(stringValue), Encoding.UTF8, "application/json");
                var result = await client.PutAsync(url, content);
                result.EnsureSuccessStatusCode();
            }
        }

        public static async Task<T> Get<T>(string url)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiBasicUri);
                var result = await client.GetAsync(url);
                result.EnsureSuccessStatusCode();
                string resultContentString = await result.Content.ReadAsStringAsync();
                T resultContent = JsonConvert.DeserializeObject<T>(resultContentString);
                return resultContent;
            }
        }

        public static async Task Delete(string url)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiBasicUri);
                var result = await client.DeleteAsync(url);
                result.EnsureSuccessStatusCode();
            }
        }
    }
}