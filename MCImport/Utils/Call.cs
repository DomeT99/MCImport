using MCImport.Models;
using RestSharp;

namespace MCImport.Utils
{
    internal class Call
    {
        public static async Task<RestResponse> GetFromService(string url)
        {
            try
            {
                using RestClient client = new();


                RestRequest request = new(url, Method.Get);

                RestResponse response = await client.GetAsync(request);

                return response;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static async void Post(Product product)
        {
            try
            {
                using McproductsContext database = new();

                await database.Products.AddAsync(product);

                database.SaveChanges();

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
