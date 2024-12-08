using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APortfolio.BLL.Services
{
    public interface IFileUploadService
    {
        Task<string> UploadImageAsync(IFormFile imageFile);
        Task<string> UploadVideoAsync(IFormFile videoFile);
    }
}
