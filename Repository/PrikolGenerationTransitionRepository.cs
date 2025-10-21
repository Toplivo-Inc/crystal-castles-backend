using CrystalCastlesBackend.Models;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;

public class PrikolGenerationTransitionRepository
{
  private CastlesDbContext _dbContext;
  public PrikolGenerationTransitionRepository(CastlesDbContext dbContext)
  {
    _dbContext = dbContext;
  }

  public async Task<List<PrikolGenerationTransition>> Get()
  {
    var prikolGenerationTransitionEntities = await _dbContext.PrikolGenerationTransition
      .AsNoTracking()
      .ToListAsync();

    return prikolGenerationTransitionEntities;
  }

  public async Task<Guid> Add(PrikolGenerationTransition prikolGenerationTransition)
  {
    var prikolGenerationTransitionEntity = new PrikolGenerationTransition
    {
      PrikolGenerationTransitionId = Guid.NewGuid(),
      PrikolId = prikolGenerationTransition.PrikolId,
      TransitionTimestamp = prikolGenerationTransition.TransitionTimestamp,
      UserId = prikolGenerationTransition.UserId,
      NewState = prikolGenerationTransition.NewState,
      Payload = prikolGenerationTransition.Payload,
      PreviousTransitionId = prikolGenerationTransition.PreviousTransitionId,
    };

    await _dbContext.AddAsync(prikolGenerationTransitionEntity);
    await _dbContext.SaveChangesAsync();

    return prikolGenerationTransitionEntity.PrikolGenerationTransitionId;

  }

  public async Task<Guid> Delete(Guid prikolGenerationTransitionId)
  {
    await _dbContext.PrikolGenerationTransition.Where(u => u.PrikolGenerationTransitionId == prikolGenerationTransitionId)
      .ExecuteDeleteAsync();
    return prikolGenerationTransitionId;
  }
  public async Task<Guid> Update(Guid prikolGenerationTransitionId, Guid prikolId, DateTime transitionTimestamp,
      Guid userId, PrikolGenerationStatusEnum newState, JsonDocument payload, Guid previousTransitionId)
  {
    await _dbContext.PrikolGenerationTransition
      .Where(i => i.PrikolGenerationTransitionId == prikolGenerationTransitionId)
      .ExecuteUpdateAsync(s => s
          .SetProperty(u => u.PrikolGenerationTransitionId, u => prikolGenerationTransitionId)
          .SetProperty(u => u.PrikolId, u => prikolId)
          .SetProperty(u => u.TransitionTimestamp, u => transitionTimestamp)
          .SetProperty(u => u.UserId, u => userId)
          .SetProperty(u => u.NewState, u => newState)
          .SetProperty(u => u.Payload, u => payload)
          .SetProperty(u => u.PreviousTransitionId, u => previousTransitionId));

    return prikolGenerationTransitionId;
  }

}
