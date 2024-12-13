using APortfolio.DAL.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace APortfolio.BLL.Services
{
    public class PortfolioService : IPortfolioService
    {
        private readonly IPortfolioRepository _portfolioRepository;
        private readonly IFileUploadService _fileUploadService;
        private readonly UserManager<AppUser> _userManager;

        public PortfolioService(IPortfolioRepository portfolioRepository, IFileUploadService fileUploadService, UserManager<AppUser> userManager)
        {
            _portfolioRepository = portfolioRepository;
            _fileUploadService = fileUploadService;
            _userManager = userManager;
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

        public async Task<Portfolio?> GetPortfolioWithProjectsAsync(int id)
        {
            return await _portfolioRepository.GetPortfolioWithProjectsAsync(id);
        }

        public async Task<IEnumerable<Portfolio>> SearchPortfoliosAsync(string keyword)
        {
            return await _portfolioRepository.SearchPortfoliosAsync(keyword);
        }

        public async Task AddAsync(string userId, Portfolio portfolio, IFormFile image)
        {
            var existingPortfolio = await _portfolioRepository.GetPortfoliosByUserIdAsync(userId);

            if (existingPortfolio.Any())
            {
                throw new InvalidOperationException("A user can only have one portfolio.");
            }

            portfolio.UserId = userId;
            portfolio.CreatedDate = DateTime.UtcNow; 
            var imageFileName = await _fileUploadService.UploadImageAsync(image);
            portfolio.Image = imageFileName; 

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
