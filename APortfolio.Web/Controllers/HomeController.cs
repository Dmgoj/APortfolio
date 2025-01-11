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

        // GET: Portfolios
        public async Task<IActionResult> Index(int? pageNumber)
        {
            // Define default page size (e.g., 10 items per page)
            const int pageSize = 10;

            // Use the provided pageNumber or default to the first page
            var pageIndex = pageNumber ?? 1;

            // Fetch the paginated list
            var portfolios = await _service.GetPaginatedPortfoliosAsync(pageIndex, pageSize);

            // Pass the paginated list to the view
            return View(portfolios);
        }




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
