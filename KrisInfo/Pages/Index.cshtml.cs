using Library;
using Library.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KrisInfo.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IKrisInfoService _krisInfoService;

        public List<KrisInfoResponse> KrisInfo { get; set; }
        public IndexModel(IKrisInfoService krisInfoService)
        {
            _krisInfoService = krisInfoService;
        }

        public async Task OnGet()
        {
            KrisInfo = await _krisInfoService.GetJsonDataAll();
        }
    }
}
