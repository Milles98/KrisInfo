using Library;
using Library.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KrisInfo.Pages
{
    public class DetailsModel : PageModel
    {
        private readonly IKrisInfoService _krisInfoService;
        public KrisInfoResponse KrisInfoResponse { get; set; }
        public DetailsModel(IKrisInfoService krisInfoService)
        {
            _krisInfoService = krisInfoService;
        }

        public async Task<IActionResult> OnGet(int id)
        {
            KrisInfoResponse = await _krisInfoService.GetJsonDataOne(id);
            if (KrisInfoResponse == null)
            {
                return RedirectToPage("/Index");
            }
            return Page();
        }
    }
}
