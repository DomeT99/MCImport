using MCImport.Models;
using MCImport.Utils;
using Newtonsoft.Json;
using RestSharp;
using System.Net;

namespace MCImport.HTTP
{
    internal class Request
    {
        private static readonly string? StaticUrl = "https://fakestoreapi.com/products";
        public static async Task<List<Product>> GetFakeStoreData()
        {
            try
            {

                RestResponse response = await Call.GetFromService(StaticUrl!);

                List<Product>? products = JsonConvert.DeserializeObject<List<Product>>(response.Content!);

                return products!;
            }
            catch (WebException ex)
            {
                throw new WebException($"Exception in GetFakeStoreData method: {ex.Message}");
            }
        }
    }
}
