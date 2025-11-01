using CrystalCastlesBackend.Models;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;
using CrystalCastlesBackend.Interfaces;

namespace CrystalCastlesBackend.Repository
{


  public class PrikolTransitionRepository(CastlesDbContext dbContext) : IPrikolTransitionRepository
  {
    private readonly CastlesDbContext _dbContext = dbContext;

    public async Task<List<PrikolTransition>> Get()
    {
      var prikolTransition = await _dbContext.PrikolTransition
        .AsNoTracking()
        .ToListAsync();

      return prikolTransition;
    }
    public async Task<Guid> Add(PrikolTransition prikolTransition)
    {
      var prikolTransitionEntities = new PrikolTransition
      {
        PrikolTransitionId = prikolTransition.PrikolTransitionId,
        PrikolId = prikolTransition.PrikolId,
        TransitionTimestamp = prikolTransition.TransitionTimestamp,
        UserId = prikolTransition.UserId,
        NewState = prikolTransition.NewState,
        Payload = prikolTransition.Payload,
        PreviousTransitionId = prikolTransition.PreviousTransitionId
      };
      await _dbContext.AddAsync(prikolTransitionEntities);
      await _dbContext.SaveChangesAsync();

      return prikolTransitionEntities.PrikolTransitionId;
    }
    public async Task<Guid> Delete(Guid prikolTransitionId)
    {
      await _dbContext.PrikolTransition.Where(i => i.PrikolTransitionId == prikolTransitionId)
        .ExecuteDeleteAsync();

      return prikolTransitionId;
    }

    public async Task<Guid> Update(Guid prikolTransitionId, Guid prikolId, DateTime transitionTimestamp,
        Guid userId, PrikolStatusEnum newState, JsonDocument payload, Guid previousTransitionId)
    {
      await _dbContext.PrikolTransition.Where(i => i.PrikolTransitionId == prikolTransitionId)
        .ExecuteUpdateAsync(s => s
            .SetProperty(u => u.PrikolTransitionId, u => prikolTransitionId)
            .SetProperty(u => u.PrikolId, u => prikolId)
            .SetProperty(u => u.TransitionTimestamp, u => transitionTimestamp)
            .SetProperty(u => u.UserId, u => userId)
            .SetProperty(u => u.NewState, u => newState)
            .SetProperty(u => u.Payload, u => payload)
            .SetProperty(u => u.PreviousTransitionId, u => previousTransitionId));

      return previousTransitionId;
    }
  }
}
