using CrystalCastlesBackend.Models;
using Microsoft.EntityFrameworkCore;

public class PrikolTransitionRepository(CastlesDbContext dbContext)
{
    private CastlesDbContext _dbContext = dbContext;

    public async Task<List<PrikolTransition>> Get()
    {

    }
    public async Task<Guid> Add()
    {

    }
    public async Task<Guid> Delete()
    {

    }

    public async Task<Guid> Update()
    {

    }
}
