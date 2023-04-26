
using HttpClient client = new();
string url = "https://localhost:7025/BatchPayment/RunBatch/?includeDateFilters=True";
var request = new HttpRequestMessage(HttpMethod.Post, url);
await client.SendAsync(request);