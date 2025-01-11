using APortfolio.DAL.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APortfolio.DAL.Repositories
{
    public class RatingRepository : IRatingRepository
    {
        private readonly ApplicationDbContext _context;

        public RatingRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddLikeDislikeAsync(LikeDislike likeDislike)
        {
            await _context.LikesDislikes.AddAsync(likeDislike);
            await _context.SaveChangesAsync();
        }

        public async Task<int> GetDislikeCountAsync(int mediaId)
        {
            return await _context.LikesDislikes.AsNoTracking().CountAsync(ld => ld.MediaId == mediaId && !ld.IsLike);
        }

        public async Task<int> GetLikeCountAsync(int mediaId)
        {
            return await _context.LikesDislikes.AsNoTracking().CountAsync(ld => ld.MediaId == mediaId && ld.IsLike);
        }

        public async Task<bool?> GetUserReactionAsync(int mediaId, string userId)
        {
            var reaction = await _context.LikesDislikes
                .AsNoTracking()
                .Where(ld => ld.MediaId == mediaId && ld.UserId == userId)
                .Select(ld => (bool?)ld.IsLike)
                .FirstOrDefaultAsync();

            return reaction; // true, false, or null (if no reaction)
        }

        public async Task RemoveLikeDislikeAsync(int mediaId, string userId)
        {
            var likeDislike = await _context.LikesDislikes.FirstOrDefaultAsync(ld => ld.MediaId == mediaId && ld.UserId == userId);

            if (likeDislike != null)
            {
                _context.LikesDislikes.Remove(likeDislike);
                await _context.SaveChangesAsync();
            }
        }
    }
}
