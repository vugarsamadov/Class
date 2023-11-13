using System.Data;
using System.Diagnostics;

HttpClient client = new HttpClient();




List<string> urls = new List<string>()
{ 
    "https://www.dtx.gov.az/az/",
    "https://google.com",
    "https://x.com",
    "https://twitter.com"
};


BenchMarkNonAwait(urls,client);
BenchMarkAwait(urls,client);

Console.ReadLine();


async void BenchMarkAwait(List<string> urls, HttpClient client)
{
    Stopwatch stopwatch = Stopwatch.StartNew();
    stopwatch.Start();
    foreach (var url in urls)
    {
        await client.GetStringAsync(url);
    }
    stopwatch.Stop();
    Console.WriteLine($"Await time: {stopwatch.Elapsed}");
}
void BenchMarkNonAwait(List<string> urls, HttpClient client)
{
    Stopwatch stopwatch = Stopwatch.StartNew();
    stopwatch.Start();
    foreach (var url in urls)
    {
        var task = client.GetStringAsync(url);
    }
    stopwatch.Stop();
    Console.WriteLine($"Non-Await time: {stopwatch.Elapsed}");
}











