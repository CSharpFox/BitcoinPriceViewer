using Microsoft.AspNetCore.Mvc.RazorPages;
using BitcoinPriceViewer.Services;

namespace BitcoinPriceViewer.Pages;

public class IndexModel : PageModel
{
    public decimal? Price { get; set; }

    public async Task OnGetAsync()
    {
        var service = new PriceService();
        Price = await service.GetBitcoinPriceAsync();
    }
}
