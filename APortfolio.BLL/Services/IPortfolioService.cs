using APortfolio.BLL.Helpers;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace APortfolio.BLL.Services
{
    public interface IPortfolioService
    {
        Task<Portfolio> GetByIdAsync(int id);
        Task<PaginatedList<Portfolio>> GetPaginatedPortfoliosAsync(int pageNumber, int pageSize);
        Task<IEnumerable<Portfolio>> GetPortfoliosByUserIdAsync(string userId);
        Task<Portfolio?> GetPortfolioWithProjectsAsync(int id);
        Task<IEnumerable<Portfolio>> SearchPortfoliosAsync(string keyword);
        Task AddAsync(string userId,Portfolio portfolio, IFormFile image);
        Task UpdateAsync(Portfolio portfolio);
        Task DeleteAsync(int id);
    }
}
