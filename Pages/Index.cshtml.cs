using ASP1.Models;
using ASP1.services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP1.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public JsonFileProductService services;
        public IEnumerable<product> products { get; private set; }
        public IndexModel(ILogger<IndexModel> logger, JsonFileProductService prodservice)
        {
            _logger = logger;
            services = prodservice;
        }

        public void OnGet()
        {
            products = services.GetProducts();

        }
    }
}
