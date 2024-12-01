using APortfolio.DAL.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APortfolio.BLL.Services
{
    public class ProjectService : IProjectService
    {
        private readonly IProjectRepository _projectRepository;
        private readonly string _imagePath;

        public ProjectService(IProjectRepository projectRepository, IConfiguration configuration)
        {
            _projectRepository = projectRepository;
            _imagePath = configuration["ImageStoragePath"];
        }

        public async Task<Project> GetByIdAsync(int id)
        {
            return await _projectRepository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<Project>> GetAllByPortfolioIdAsync(int portfolioId)
        {
            return await _projectRepository.GetAllByPortfolioIdAsync(portfolioId);
        }

        public async Task<string> SaveImageAsync(IFormFile image)
        {
            if (image == null || image.Length == 0)
            {
                throw new ArgumentException("Invalid image file.");
            }

            // Generate filename with a timestamp
            var timestamp = DateTime.Now.ToString("ddMMyyyy_HHmmss");
            var fileName = $"{timestamp}_{Path.GetFileName(image.FileName)}";
            var filePath = Path.Combine("wwwroot", _imagePath, fileName);

            // Save the file to the designated path
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await image.CopyToAsync(stream);
            }

            // Return the relative path (to be stored in the database)
            return "/" + Path.Combine(_imagePath, fileName).Replace("\\", "/");
        }


        public async Task AddAsync(Project project)
        {
            // You can add any additional business logic here, such as validation
            project.CreatedDate = DateTime.UtcNow;
            await _projectRepository.AddAsync(project);
        }

        public async Task AddMediaAsync(Media media)
        {
           
            await _projectRepository.AddMediaAsync(media);
        }

        public async Task DeleteMediaAsync(int id)
        {
          
            await _projectRepository.DeleteMediaAsync(id);
        }



        public async Task UpdateAsync(Project project)
        {
            await _projectRepository.UpdateAsync(project);
        }

        public async Task DeleteAsync(int id)
        {
            await _projectRepository.DeleteAsync(id);
        }
    }

}
