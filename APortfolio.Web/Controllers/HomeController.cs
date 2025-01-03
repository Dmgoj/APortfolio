using APortfolio.BLL.Services;
using APortfolio.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace APortfolio.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IPortfolioService _service;

        public HomeController(ILogger<HomeController> logger, IPortfolioService portfolioService)
        {
            _logger = logger;
            _service = portfolioService;
        }

        public async Task<IActionResult> Index()
        {
            var portfolios = await _service.GetAllAsync();
            return View(portfolios);
        }

      

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
