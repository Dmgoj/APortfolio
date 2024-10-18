using APortfolio.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APortfolio.BLL.Services
{
    public class PortfolioService : IPortfolioService
    {
        private readonly IPortfolioRepository _portfolioRepository;

        public PortfolioService(IPortfolioRepository portfolioRepository)
        {
            _portfolioRepository = portfolioRepository;
        }

        public async Task<Portfolio> GetByIdAsync(int id)
        {
            return await _portfolioRepository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<Portfolio>> GetAllAsync()
        {
            return await _portfolioRepository.GetAllAsync();
        }

        public async Task<IEnumerable<Portfolio>> GetPortfoliosByUserIdAsync(string userId)
        {
            return await _portfolioRepository.GetPortfoliosByUserIdAsync(userId);
        }

        public async Task<IEnumerable<Portfolio>> SearchPortfoliosAsync(string keyword)
        {
            return await _portfolioRepository.SearchPortfoliosAsync(keyword);
        }

        public async Task AddAsync(Portfolio portfolio)
        {
            await _portfolioRepository.AddAsync(portfolio);
        }

        public async Task UpdateAsync(Portfolio portfolio)
        {
            await _portfolioRepository.UpdateAsync(portfolio);
        }

        public async Task DeleteAsync(int id)
        {
            await _portfolioRepository.DeleteAsync(id);
        }
    }
}
