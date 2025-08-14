using System.Text.Json;

namespace BitcoinPriceViewer.Services;

public class PriceService
{
    private readonly HttpClient _http = new();

    public async Task<decimal?> GetBitcoinPriceAsync()
    {
        var response = await _http.GetAsync("https://api.coingecko.com/api/v3/simple/price?ids=bitcoin&vs_currencies=usd");
        if (!response.IsSuccessStatusCode)
            return null;

        var json = await response.Content.ReadAsStringAsync();

        using var doc = JsonDocument.Parse(json);
        var root = doc.RootElement;

        if (root.TryGetProperty("bitcoin", out var bitcoinProp) &&
            bitcoinProp.TryGetProperty("usd", out var usdProp) &&
            usdProp.TryGetDecimal(out var price))
        {
            return price;
        }

        return null;
    }
}
