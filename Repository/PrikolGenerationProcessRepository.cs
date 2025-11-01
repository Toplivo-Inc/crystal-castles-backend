using CrystalCastlesBackend.Models;
using Microsoft.EntityFrameworkCore;
using CrystalCastlesBackend.Interfaces;

namespace CrystalCastlesBackend.Repository
{

  public class PrikolGenerationProcessRepository : IPrikolGenerationProcessRepository
  {
    private CastlesDbContext _dbContext;
    public PrikolGenerationProcessRepository(CastlesDbContext dbContext)
    {
      _dbContext = dbContext;
    }

    public async Task<List<PrikolGenerationProcess>> Get()
    {
      var prikolGenerationsProcesses = await _dbContext.PrikolGenerationProcesses
        .AsNoTracking()
        .ToListAsync();

      return prikolGenerationsProcesses;
    }

    public async Task<Guid> Add(PrikolGenerationProcess prikolGenerationProces)
    {
      var prikilGenerationProcess = new PrikolGenerationProcess
      {
        PrikolId = prikolGenerationProces.PrikolId,
        Prikol = prikolGenerationProces.Prikol,
        Status = prikolGenerationProces.Status,
        ErrorMessage = prikolGenerationProces.ErrorMessage,
        CreatedAt = prikolGenerationProces.CreatedAt,
        UpdatedAt = prikolGenerationProces.UpdatedAt
      };
      await _dbContext.AddAsync(prikilGenerationProcess);
      await _dbContext.SaveChangesAsync();

      return prikilGenerationProcess.PrikolId;
    }

    public async Task<Guid> Delete(Guid prikolId)
    {
      await _dbContext.PrikolGenerationProcesses
        .Where(u => u.PrikolId == prikolId)
        .ExecuteDeleteAsync();

      return prikolId;
    }

    public async Task<Guid> Update(Guid prikolId, PrikolGenerationStatusEnum status,
        string errorMessage, DateTime createdAt, DateTime updatedAt)
    {
      await _dbContext.PrikolGenerationProcesses
        .Where(i => i.PrikolId == prikolId)
        .ExecuteUpdateAsync(s => s
            .SetProperty(u => u.Status, u => status)
            .SetProperty(u => u.ErrorMessage, u => errorMessage)
            .SetProperty(u => u.CreatedAt, u => createdAt)
            .SetProperty(u => u.UpdatedAt, u => updatedAt));

      return prikolId;

    }
  }
}
