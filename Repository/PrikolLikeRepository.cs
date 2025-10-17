using CrystalCastlesBackend.Models;
using Microsoft.EntityFrameworkCore;

public class PrikolLikeRepository
{
    private CastlesDbContext _dbContext;
    public PrikolLikeRepository(CastlesDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<List<PrikolLike>> Get()
    {
      
    }

    public async Task<Guid> Add()
    {

    }
    public async Task<Guid> Delete()
    {

    }
    public async Task<GUid> Update()
    {


    }


}
