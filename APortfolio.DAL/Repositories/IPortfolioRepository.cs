//using APortfolio.DAL.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace APortfolio.DAL.Repositories
{
    public interface IPortfolioRepository
    {
        Task<Portfolio> GetByIdAsync(int id);
        public IQueryable<Portfolio> GetAllAsQueryable();
        Task<IEnumerable<Portfolio>> GetPortfoliosByUserIdAsync(string userId);
        Task<Portfolio?> GetPortfolioWithProjectsAsync(int portfolioId);
        Task<IEnumerable<Portfolio>> SearchPortfoliosAsync(string keyword);
        Task AddAsync(Portfolio portfolio);
        Task UpdateAsync(Portfolio portfolio);
        Task DeleteAsync(int id);
    }

}
