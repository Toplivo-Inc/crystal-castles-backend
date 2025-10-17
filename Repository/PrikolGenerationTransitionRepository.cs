using CrystalCastlesBackend.Models;
using Microsoft.EntityFrameworkCore;

public class PrikolGenerationTransitionRepository
{
    private CastlesDbContext _dbContext;
    public PrikolGenerationTransitionRepository(CastlesDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<List<PrikolGenerationTransition>> Get()
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
