using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace APortfolio.BLL.Services
{
    public class FileUploadService : IFileUploadService
    {
        private readonly string _imagePath;

        public FileUploadService(IConfiguration configuration)
        {
            _imagePath = configuration["ImageStoragePath"];
        }

        public async Task<string> UploadImageAsync(IFormFile image)
        {
            if (image == null || image.Length == 0)
            {
                return "/images/projects/default.jpeg";
            }

            // Generate filename with a timestamp
            var timestamp = DateTime.Now.ToString("ddMMyyyy_HHmmss");
            var fileName = $"{timestamp}_{Path.GetFileName(image.FileName)}";
            var filePath = Path.Combine("wwwroot", _imagePath, fileName);

            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await image.CopyToAsync(stream);
            }

            return Path.Combine("/",_imagePath, fileName).Replace("\\", "/"); ;
        }

        public Task<string> UploadVideoAsync(IFormFile videoFile)
        {
            throw new NotImplementedException();
        }
    }
}
