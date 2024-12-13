using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using APortfolio.DAL.Data;
using APortfolio.DAL.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using APortfolio.BLL.Services;

namespace APortfolio.Web.Controllers
{
    public class PortfolioController : Controller
    {
        private readonly IPortfolioService  _service;

        public PortfolioController(IPortfolioService service)
        {
            _service = service;
        }

        // GET: Portfolios
        public async Task<IActionResult> Index()
        {
            var portfolios = await _service.GetAllAsync();
            return View(portfolios);
        }

        // GET: Portfolios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            // var portfolio = await _service.GetByIdAsync(id.Value);
            var portfolio = await _service.GetPortfolioWithProjectsAsync(id.Value);

            if (portfolio == null)
            {
                return NotFound(); // Return NotFound if portfolio is not found
            }

            return View(portfolio);
        }

        // GET: Portfolios/Create
        [Authorize]
        public IActionResult Create()
        {
            //ViewData["UserId"] = new SelectList(_service.AppUsers, "Id", "Id");
            return View();
        }

        // POST: Portfolios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Create(Portfolio portfolio,IFormFile image)
        {
            // Get the logged-in user's ID
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            portfolio.UserId = userId;
            try
            {
                // Pass the userId to the service layer
                await _service.AddAsync(userId, portfolio,image);
            }
            catch (InvalidOperationException ex)
            {
                // Pass the error message to the view
                ViewData["ErrorMessage"] = ex.Message;
                return View("Create", portfolio);
            }
            return RedirectToAction("Index");

        }
        //// GET: Portfolios/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var portfolio = await _service.FindAsync(id);
        //    if (portfolio == null)
        //    {
        //        return NotFound();
        //    }
        //    ViewData["UserId"] = new SelectList(_service.AppUsers, "Id", "Id", portfolio.UserId);
        //    return View(portfolio);
        //}

        //// POST: Portfolios/Edit/5
        //// To protect from overposting attacks, enable the specific properties you want to bind to.
        //// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Description,CreatedDate,UserId")] Portfolio portfolio)
        //{
        //    if (id != portfolio.Id)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _service.Update(portfolio);
        //            await _service.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!PortfolioExists(portfolio.Id))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    ViewData["UserId"] = new SelectList(_service.AppUsers, "Id", "Id", portfolio.UserId);
        //    return View(portfolio);
        //}

        // GET: Portfolios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var portfolio = await _service.GetByIdAsync(id.Value);
              
            if (portfolio == null)
            {
                return NotFound();
            }

            return View(portfolio);
        }

        // POST: Portfolios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var portfolio = await _service.GetByIdAsync(id);
            
            if (portfolio == null)
            {
                return NotFound();
            }

            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
