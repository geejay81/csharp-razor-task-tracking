using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Tasker.Pages
{
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public class CreatTaskModel : PageModel
    {
        private readonly ILogger<CreatTaskModel> _logger;

        public Task NewTask;

        public CreatTaskModel(ILogger<CreatTaskModel> logger)
        {
            _logger = logger;
        }


    }
}
