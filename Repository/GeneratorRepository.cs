using CrystalCastlesBackend.Models;
using Microsoft.EntityFrameworkCore;
using CrystalCastlesBackend.Interfaces;

namespace CrystalCastlesBackend.Repository
{
  public class GeneratorRepository : IGeneratorRepository
  {

    private CastlesDbContext _dbContext;
    public GeneratorRepository(CastlesDbContext dbContext)
    {
      _dbContext = dbContext;
    }

    public async Task<List<Generator>> Get()
    {

      var generators = await _dbContext.Generators
        .AsNoTracking()
        .ToListAsync();

      return generators;
    }

    public async Task<Guid> Add(Generator generator)
    {
      var generatorEntity = new Generator
      {
        GeneratorId = generator.GeneratorId,
        Key = generator.Key,
        Name = generator.Name,
        Description = generator.Description,
        ImageUrl = generator.ImageUrl
      };
      await _dbContext.AddAsync(generatorEntity);
      await _dbContext.SaveChangesAsync();

      return generatorEntity.GeneratorId;
    }

    public async Task<Guid> Delete(Guid generatorId)
    {

      await _dbContext.Generators.Where(g => g.GeneratorId == generatorId)
        .ExecuteDeleteAsync();

      return generatorId;
    }

    public async Task<Guid> Update(Guid generatorId, string key, string name,
        string description, string imageUrl)
    {
      await _dbContext.Generators.Where(i => i.GeneratorId == generatorId)
        .ExecuteUpdateAsync(s => s
      .SetProperty(u => u.GeneratorId, u => generatorId)
      .SetProperty(u => u.Key, u => key)
      .SetProperty(u => u.Name, u => name)
      .SetProperty(u => u.Description, u => description)
      .SetProperty(u => u.ImageUrl, u => imageUrl));

      return generatorId;
    }
  }
}
