using MCImport.HTTP;
using MCImport.Models;
using MCImport.Utils;

namespace MCImport
{
    internal class Program
    {
        static async Task Main()
        {

            List<Product> products = await Request.GetFakeStoreData();


            products.ForEach(product =>
            {
                product.Quantity = Utility.GenerateRandomNumber();

                Call.Post(product);
            });

            Console.WriteLine("Import successfully!");
        }
    }
}
