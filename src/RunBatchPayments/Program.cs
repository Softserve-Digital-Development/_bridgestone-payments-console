
string url = "https://localhost:7025/BatchPayment/RunBatch/?includeDateFilters=True";
var request = new HttpRequestMessage(HttpMethod.Post, url);

try
{
    using HttpClient client = new();
    client.Timeout = new TimeSpan(0, 1, 0, 0); // Will wait for an hour
    var response = await client.SendAsync(request);
    Console.WriteLine(response);
}
catch (Exception e)
{
    Console.WriteLine(e);
}