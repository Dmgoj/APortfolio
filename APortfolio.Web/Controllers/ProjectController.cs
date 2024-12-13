using APortfolio.BLL.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace APortfolio.Web.Controllers
{
    public class ProjectController : Controller
    {
        private readonly IProjectService _projectService;
        private readonly IPortfolioService _portfolioService;
        private readonly IFileUploadService _fileUploadService;

        public ProjectController(IProjectService projectService, IPortfolioService portfolioService, IFileUploadService fileUploadService)
        {
            _projectService = projectService;
            _portfolioService = portfolioService;
            _fileUploadService = fileUploadService;
        }

        public async Task<IActionResult> Index(int portfolioId)
        {
            var projects = await _projectService.GetAllByPortfolioIdAsync(portfolioId);
            return View(projects);
        }

        public async Task<IActionResult> Details(int id)
        {

            var project = await _projectService.GetByIdAsync(id);
            if (project == null)
            {
                return NotFound();
            }
            return View(project);
        }

        public IActionResult Create(int portfolioId)
        {
            return View(new Project { PortfolioId = portfolioId });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Project project, IFormFile imageFile)
        {

            ModelState.Remove("Portfolio");
            if (ModelState.IsValid)
            {
                await _projectService.AddAsync(project, imageFile);
            }
            return RedirectToAction("Details", "Portfolio", new { id = project.PortfolioId });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> AddMedia(int projectId, IFormFile mediaFile)
        {
            if (mediaFile == null || mediaFile.Length == 0)
            {
                ModelState.AddModelError("mediaFile", "Please select a valid file to upload.");
                return RedirectToAction("Details", new { id = projectId });
            }

            try
            {
                var mediaUrl = await _fileUploadService.UploadImageAsync(mediaFile);

                // Optionally, add media to the project's media collection or database
                var media = new Media
                {
                    ProjectId = projectId,
                    Url = mediaUrl,
                };

                await _projectService.AddMediaAsync(media);

                // Redirect back to project details
                return RedirectToAction("Details", new { id = projectId });
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, $"An error occurred while uploading the media: {ex.Message}");
                return RedirectToAction("Details", new { id = projectId });
            }
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> DeleteMedia(int id, int projectId)
        {

            await _projectService.DeleteMediaAsync(id);
            return RedirectToAction("Details", new { id = projectId });
        }


        public async Task<IActionResult> Edit(int id)
        {
            var project = await _projectService.GetByIdAsync(id);
            if (project == null)
            {
                return NotFound();
            }
            return View(project);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Project project)
        {
            if (ModelState.IsValid)
            {
                await _projectService.UpdateAsync(project);
                return RedirectToAction("Index", new { portfolioId = project.PortfolioId });
            }
            return View(project);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var project = await _projectService.GetByIdAsync(id);
            if (project == null)
            {
                return NotFound();
            }
            return View(project);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var project = await _projectService.GetByIdAsync(id);
            if (project != null)
            {
                await _projectService.DeleteAsync(id);
            }
            return RedirectToAction("Details", "Portfolio", new { id = project?.PortfolioId });
        }
    }

}
