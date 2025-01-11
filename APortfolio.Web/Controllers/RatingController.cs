using APortfolio.BLL.Services;
using APortfolio.Web.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;

namespace APortfolio.Web.Controllers
{


    public class RatingController : Controller
    {
        private readonly IRatingService _ratingService;

        public RatingController(IRatingService ratingService)
        {
            _ratingService = ratingService;
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> AddReaction([FromBody] AddReactionDTO data)
        {
            int mediaId = data.MediaId;
            bool isLike = data.IsLike;
            var userId = User?.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;

            if (string.IsNullOrEmpty(userId))
            {
                return Unauthorized("You must be logged in to perform this action.");
            }

            try
            {
                await _ratingService.AddLikeDislikeAsync(mediaId, userId, isLike);
                return Ok(new { success = true, message = "Reaction updated successfully." });
            }
            catch (Exception ex)
            {
                return BadRequest(new { success = false, message = ex.Message });
            }


        }

        [HttpGet]
        public async Task<IActionResult> GetLikeCount(int mediaId)
        {
            try
            {
                var likeCount = await _ratingService.GetLikesCountAsync(mediaId);
                return Ok(new { success = true, likeCount });
            }
            catch (Exception ex)
            {

                return BadRequest(new { success = false, message = ex.Message });
            }
        }

        // Get dislike count for a specific media
        [HttpGet]
        public async Task<IActionResult> GetDislikeCount(int mediaId)
        {
            try
            {
                var dislikeCount = await _ratingService.GetDislikesCountAsync(mediaId);
                return Ok(new { success = true, dislikeCount });
            }
            catch (Exception ex)
            {
                return BadRequest(new { success = false, message = ex.Message });
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetUserReaction(int mediaId)
        {
            var userId = User?.Identity?.Name;

            if (string.IsNullOrEmpty(userId))
            {
                return Unauthorized("You must be logged in to perform this action.");
            }

            try
            {
                var reaction = await _ratingService.GetUserReactionAsync(mediaId, userId);
                return Ok(new { success = true, reaction });
            }
            catch (Exception ex)
            {
                return BadRequest(new { success = false, message = ex.Message });
            }
        }
    }
}
