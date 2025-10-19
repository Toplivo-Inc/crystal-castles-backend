using CrystalCastlesBackend.Models;
using Microsoft.EntityFrameworkCore;

public class PrikolRepository
{
    private CastlesDbContext _dbContext;
    public PrikolRepository(CastlesDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public async Task<List<Prikol>> Get()
    {
        var prikolEntities = await _dbContext.Prikols
          .AsNoTracking()
          .ToListAsync();
        return prikolEntities;
    }
    public async Task<Guid> Add(Prikol prikol)
    {
        var prikolEntity = new Prikol
        {
            PrikolId = prikol.PrikolId,
            ImageUrl = prikol.ImageUrl,
            Description = prikol.Description,
            Status = prikol.Status,
            BanMessage = prikol.BanMessage,
            UserId = prikol.UserId,
            GeneratorId = prikol.GeneratorId,
            CreatedAt = prikol.CreatedAt,
            BannedAt = prikol.BannedAt
        };
        await _dbContext.AddAsync(prikolEntity);
        await _dbContext.SaveChangesAsync();

        return prikolEntity.PrikolId;
    }

    public async Task<Guid> Delete(Guid prikolId)
    {
        await _dbContext.Prikols.Where(i => i.PrikolId == prikolId)
          .ExecuteDeleteAsync();

        return prikolId;
    }

    public async Task<Guid> Update(Guid prikolId, string imageUrl, string description, PrikolStatusEnum status,
        string banMessage, Guid userId, Guid generatorId, DateTime createdAt, DateTime bannedAt)
    {
        await _dbContext.Prikols.Where(i => i.PrikolId == prikolId)
          .ExecuteUpdateAsync(s => s
              .SetProperty(u => u.ImageUrl, u => imageUrl)
              .SetProperty(u => u.Description, u => description)
              .SetProperty(u => u.Status, u => status)
              .SetProperty(u => u.BanMessage, u => banMessage)
              .SetProperty(u => u.UserId, u => userId)
              .SetProperty(u => u.GeneratorId, u => generatorId)
              .SetProperty(u => u.CreatedAt, u => createdAt)
              .SetProperty(u => u.BannedAt, u => bannedAt));
        
        return prikolId;
    }
}







