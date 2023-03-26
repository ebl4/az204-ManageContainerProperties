using Azure;
using Azure.Storage.Blobs;

namespace az204_ManageContainerProperties
{
    public class RetrieveContainerProperties
    {
        public static async Task ReadContainerPropertiesAsync(BlobContainerClient container)
        {
            try
            {
                var properties = await container.GetPropertiesAsync();
                Console.WriteLine($"Properties for container {container.Uri}");
                Console.WriteLine($"Public access level: {properties.Value.PublicAccess}");
                Console.WriteLine($"Last modified time in UTC: {properties.Value.LastModified}");
            } catch (RequestFailedException ex) {
                Console.WriteLine($"HTTP error code {ex.Status}: {ex.ErrorCode}");
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
            

        }
    }
}
