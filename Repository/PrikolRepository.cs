using CrystalCastlesBackend.Models;
using Microsoft.EntityFrameworkCore;

public class PrikolRepository
{
    private CastlesDbContext _dbContext;
    public PrikolRepository(CastlesDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public async Task<List<Prikol>> Get(){
      
    }
    public async Task<Guid> Add(){
      
    }
    public async Task<Guid> Delete(){
      
    }
    public async Task<Guid> Update(){
      
    }
}







