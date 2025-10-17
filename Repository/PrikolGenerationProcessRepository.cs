using CrystalCastlesBackend.Models;
using Microsoft.EntityFrameworkCore;

public class PrikolGenerationProcessRepository
{

    private CastlesDbContext _dbContext;
    public PrikolGenerationProcessRepository(CastlesDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<List<PrikolGenerationProcess> Get()
    {
        var prikolGenerationsProcesses = await _dbContext.PrikolGenerationProcesses
          .AsNoTracking()
          .ToListAsync();

        return prikolGenerationsProcesses;
    }

    public async Task<Guid> Add()
    {

    }

    public async Task<Guid> Delete(Guid prikolId)
    {
        await _dbContext.PrikolGenerationProcesses
          .Where(u => u.PrikolId == prikolId)
          .ExecuteDeleteAsync();
        
        return prikolId;
    }

}
