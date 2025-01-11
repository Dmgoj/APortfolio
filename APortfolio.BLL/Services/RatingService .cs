using APortfolio.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APortfolio.BLL.Services
{
    public class RatingService : IRatingService
    {
        private readonly IRatingRepository _ratingRepository;

        public RatingService(IRatingRepository ratingRepository)
        {
            _ratingRepository = ratingRepository;
        }

        public async Task AddLikeDislikeAsync(int mediaId, string userId, bool isLike)
        {
            var existingReaction = await _ratingRepository.GetUserReactionAsync(mediaId, userId);

            if (existingReaction.HasValue)
            {
                if (existingReaction.Value != isLike)
                {
                    await _ratingRepository.RemoveLikeDislikeAsync(mediaId, userId);
                    var likeDislike = new LikeDislike
                    {
                        MediaId = mediaId,
                        UserId = userId,
                        IsLike = isLike
                    };
                    await _ratingRepository.AddLikeDislikeAsync(likeDislike);
                }
                else
                {
                    await _ratingRepository.RemoveLikeDislikeAsync(mediaId, userId);
                }
            }
            else
            {
                var likeDislike = new LikeDislike
                {
                    MediaId = mediaId,
                    UserId = userId,
                    IsLike = isLike
                };
                await _ratingRepository.AddLikeDislikeAsync(likeDislike);
            }
        }

        public async Task<int> GetDislikesCountAsync(int mediaId)
        {
            return await _ratingRepository.GetDislikeCountAsync(mediaId);
        }

        public async Task<int> GetLikesCountAsync(int mediaId)
        {
            return await _ratingRepository.GetLikeCountAsync(mediaId);
        }

        public async Task<bool?> GetUserReactionAsync(int mediaId, string userId)
        {
            return await _ratingRepository.GetUserReactionAsync(mediaId, userId);
        }
    }
}
