using APortfolio.DAL.Data;
using APortfolio.DAL.Entities;

//using APortfolio.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APortfolio.DAL.Repositories
{
    public class PortfolioRepository : IPortfolioRepository
    {
        private readonly ApplicationDbContext _context;

        public PortfolioRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Portfolio> GetByIdAsync(int id)
        {
            return await _context.Portfolios
                .Include(p=>p.User)
                .Include(p => p.Projects)  // Ensure that projects are included
                .FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<Portfolio?> GetPortfolioWithProjectsAsync(int id)
        {
            return await _context.Portfolios
                .Include(p => p.Projects)
                .FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<IEnumerable<Portfolio>> GetAllAsync() //TODO napraviti paging da ne vrati čitavu bazu u memory
        {
            return await _context.Portfolios
         .Include(p => p.User)  // Ensure the User is loaded
         .ToListAsync();
        }

        public async Task<IEnumerable<Portfolio>> GetPortfoliosByUserIdAsync(string userId)
        {
            return await _context.Portfolios.Where(p => p.UserId == userId).ToListAsync();
        }

        public async Task<IEnumerable<Portfolio>> SearchPortfoliosAsync(string keyword)
        {
            return await _context.Portfolios
                .Where(p => p.Title.Contains(keyword) || p.Description.Contains(keyword))
                .ToListAsync();
        }

        public async Task AddAsync(Portfolio portfolio)
        {
            await _context.Portfolios.AddAsync(portfolio);
            await _context.SaveChangesAsync();
        }

       

        public async Task UpdateAsync(Portfolio portfolio)
        {
            _context.Portfolios.Update(portfolio);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var portfolio = await GetByIdAsync(id);
            if (portfolio != null)
            {
                _context.Portfolios.Remove(portfolio);
                await _context.SaveChangesAsync();
            }
        }
    }

}
