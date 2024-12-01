using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APortfolio.BLL.Services
{
    public interface IProjectService
    {
        Task<Project> GetByIdAsync(int id);
        Task<IEnumerable<Project>> GetAllByPortfolioIdAsync(int portfolioId);
        Task AddAsync(Project project);
        Task AddMediaAsync(Media media);
        Task DeleteMediaAsync(int id);
        Task UpdateAsync(Project project);
        Task DeleteAsync(int id);
        Task<string> SaveImageAsync(IFormFile imageUrl);
    }

}
