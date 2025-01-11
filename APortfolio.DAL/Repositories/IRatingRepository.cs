using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APortfolio.DAL.Repositories
{
    public interface IRatingRepository
    {
        Task AddLikeDislikeAsync(LikeDislike likeDislike);
        Task RemoveLikeDislikeAsync(int mediaId, string userId);
        Task<int> GetLikeCountAsync(int mediaId);
        Task<int> GetDislikeCountAsync(int mediaId);
        Task<bool?> GetUserReactionAsync(int mediaId, string userId);
    }
}
