using CrystalCastlesBackend.Models;
using Microsoft.EntityFrameworkCore;
using CrystalCastlesBackend.Interfaces;

namespace CrystalCastlesBackend.Repository
{
  public class PrikolLikeRepository : IPrikolLikeRepository
  {
    private CastlesDbContext _dbContext;
    public PrikolLikeRepository(CastlesDbContext dbContext)
    {
      _dbContext = dbContext;
    }

    public async Task<List<PrikolLike>> Get()
    {
      var prikolLikes = await _dbContext.PrikolLikes
        .AsNoTracking()
        .ToListAsync();

      return prikolLikes;
    }

    public async Task<Guid> Add(PrikolLike prikolLike)
    {
      var prikolLikesEntities = new PrikolLike
      {
        PrikolLikeId = prikolLike.PrikolLikeId,
        UserId = prikolLike.UserId,
        PrikolId = prikolLike.PrikolId,
        CreatedAt = prikolLike.CreatedAt
      };
      await _dbContext.AddAsync(prikolLikesEntities);
      await _dbContext.SaveChangesAsync();

      return prikolLikesEntities.PrikolLikeId;
    }
    public async Task<Guid> Delete(Guid prikolLikeId)
    {
      await _dbContext.PrikolLikes.Where(i => i.PrikolLikeId == prikolLikeId)
        .ExecuteDeleteAsync();

      return prikolLikeId;
    }
    public async Task<Guid> Update(Guid prikolLikeId, Guid userId, Guid prikolId, DateTime createdAt)
    {
      await _dbContext.PrikolLikes.Where(i => i.PrikolLikeId == prikolLikeId)
         .ExecuteUpdateAsync(s => s

            .SetProperty(u => u.PrikolLikeId, u => prikolLikeId)
            .SetProperty(u => u.UserId, u => userId)
            .SetProperty(u => u.PrikolId, u => prikolId)
            .SetProperty(u => u.CreatedAt, u => createdAt));

      return prikolLikeId;
    }


  }
}
