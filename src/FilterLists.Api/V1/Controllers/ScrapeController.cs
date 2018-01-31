﻿using System.Threading.Tasks;
using FilterLists.Services.ScrapeService;
using Microsoft.AspNetCore.Mvc;

namespace FilterLists.Api.V1.Controllers
{
    public class ScrapeController : BaseController
    {
        private readonly ScrapeService scrapeService;

        public ScrapeController(ScrapeService scrapeService)
        {
            this.scrapeService = scrapeService;
        }

        [HttpPost]
        public async Task<IActionResult> Index()
        {
#if DEBUG
            await scrapeService.ScrapeAsync(3);
            return Ok();
#else
            return StatusCode(403);
#endif
        }
    }
}