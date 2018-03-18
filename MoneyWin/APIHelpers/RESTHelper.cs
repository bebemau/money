using MoneyWin.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MoneyWin.APIHelpers
{
    public class RESTHelper
    {
        public static async Task<List<T>> GetListOfObjects<T>(string uri, HttpClient client)
        {
            var returnobj = new List<T>();
            try
            {
                var response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    returnobj = JsonConvert.DeserializeObject<List<T>>(content);
                }
            }
            catch
            {
                return new List<T>();
            }
            return returnobj;
        }

        public static async Task<T> GetSingleObject<T>(string uri, HttpClient client)
        {
            try
            {
                var response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var result = JsonConvert.DeserializeObject<T>(content);
                    return (T)Convert.ChangeType(result, typeof(T));
                }
            }
            catch
            {
                return default(T);
            }

            return default(T);
        }

        public static async Task<List<TResponse>> PostListOfObjects<TRequest, TResponse>(TRequest request, string uri, HttpClient client)
        {
            var returnobj = new List<TResponse>();
            try
            {
                var response = await client.PostAsJsonAsync(uri, request);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    returnobj = JsonConvert.DeserializeObject<List<TResponse>>(content);
                }
            }
            catch (Exception ex)
            {
                return new List<TResponse>();
            }
            return returnobj;
        }

        public static async Task<TResponse> PostListOfObjectsGetSingle<TRequest, TResponse>(TRequest request, string uri, HttpClient client)
        {
            try
            {
                var response = await client.PostAsJsonAsync(uri, request);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var result = JsonConvert.DeserializeObject<TResponse>(content);
                    return (TResponse)Convert.ChangeType(result, typeof(TResponse));
                }
            }
            catch
            {
                return default(TResponse);
            }

            return default(TResponse);
        }
    }
}
