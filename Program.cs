class Program
{
    public static async Task<int> GetPageLengthAsync(string endpoint)
    {
        var client = new HttpClient();
        var uri = new Uri(endpoint);
        byte[] content = await client.GetByteArrayAsync(uri);
        return content.Length;
    }
    public static async Task Main()
    {
        int size = await GetPageLengthAsync("https://nadjibmouhoun.me");
        Console.WriteLine($"Page size: {size} byte");

    }
}

