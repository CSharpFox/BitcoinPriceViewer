using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BitcoinPriceViewer.Services;

namespace BitcoinPriceViewer.Pages;

public class PriceModel : PageModel
{
    public async Task<JsonResult> OnGetAsync()
    {
        var service = new PriceService();
        var price = await service.GetBitcoinPriceAsync();
        return new JsonResult(new { price });
    }
}
