using MCImport.HTTP;
using MCImport.Models;
using MCImport.Utils;

namespace MCImport
{
    internal class Program
    {
        static async Task Main()
        {

            try
            {
                List<Product> products = await Request.GetFakeStoreData();
                Random randomNumber = new();

                products.ForEach(product =>
                {
                    product.Quantity = randomNumber.Next(1, 100);

                    Call.Post(product);
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
