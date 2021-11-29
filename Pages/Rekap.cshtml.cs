using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Absensi.Pages
{
    public class RekapModel : PageModel
    {

        private readonly ILogger<RekapModel> _logger;

        public RekapModel(ILogger<RekapModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
        }
    }
}
