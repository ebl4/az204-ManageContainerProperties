using az204_ManageContainerProperties;
using Azure.Storage.Blobs;

string connectionString = "CONNECTION_STRING";
string containerName = "wtblob" + Guid.NewGuid().ToString();

BlobServiceClient blobServiceClient = new BlobServiceClient(connectionString);

BlobContainerClient containerClient = await blobServiceClient.CreateBlobContainerAsync(containerName);

await RetrieveContainerProperties.ReadContainerPropertiesAsync(containerClient);
