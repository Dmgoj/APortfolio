using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APortfolio.BLL.Services
{
    public interface IRatingService
    {
        Task AddLikeDislikeAsync(int mediaId, string userId, bool isLike);
        Task<int> GetLikesCountAsync(int mediaId);
        Task<int> GetDislikesCountAsync(int mediaId);
        Task<bool?> GetUserReactionAsync(int mediaId, string userId);
    }
}
