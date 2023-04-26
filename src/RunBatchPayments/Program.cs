
using HttpClient client = new();
string url = "https://localhost:7025/BatchPayment/RunBatch/?includeDateFilters=True";
var request = new HttpRequestMessage(HttpMethod.Post, url);
await ProcessAsync(client, request);

static async Task ProcessAsync(HttpClient client, HttpRequestMessage request)
{
    var json = await client.SendAsync(request);
    Console.WriteLine(json);
}