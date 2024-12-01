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
        private readonly UserManager<AppUser> _userManager;
        private readonly string _imagePath;

        public PortfolioService(IPortfolioRepository portfolioRepository, UserManager<AppUser> userManager, IConfiguration configuration)
        {
            _portfolioRepository = portfolioRepository;
            _userManager = userManager;
            _imagePath = configuration["ImageStoragePath"];
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

        public async Task<string> SaveImageAsync(IFormFile image)
        {
             
            if (image == null || image.Length == 0)
            {
               return "/images/projects/default.jpeg";
            }

            // Generate filename with a timestamp
            var timestamp = DateTime.Now.ToString("ddMMyyyy_HHmmss");
            var fileName = $"{timestamp}_{Path.GetFileName(image.FileName)}";
            var filePath = Path.Combine("wwwroot",_imagePath, fileName);

            // Save the file to the designated path
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await image.CopyToAsync(stream);
            }

            // Return the relative path (to be stored in the database)
            return Path.Combine(_imagePath, fileName).Replace("\\", "/");   
        }

        public async Task AddAsync(string userId, Portfolio portfolio, IFormFile image)
        {
            // Check if the user already has a portfolio
            var existingPortfolio = await _portfolioRepository.GetPortfoliosByUserIdAsync(userId);
            if (existingPortfolio.Any())
            {
                throw new InvalidOperationException("A user can only have one portfolio.");
            }

            // Assign the userId to the portfolio
            portfolio.UserId = userId;
            portfolio.CreatedDate = DateTime.UtcNow; // Set the current time as the created date

            // If an image is provided, save it and set the Image property
          
                var imageFileName = await SaveImageAsync(image);
                portfolio.Image = imageFileName; // Store the file name in the portfolio
            

            // Now add the portfolio to the repository
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
