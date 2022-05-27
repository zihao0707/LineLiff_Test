using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace __NameSpace__.Pages
{
    public class LiffModel : PageModel
    {
        private readonly ILogger<LiffModel> _logger;

        public LiffModel(ILogger<LiffModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
