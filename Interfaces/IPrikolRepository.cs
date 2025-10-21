using CrystalCastlesBackend.Models;

public interface IGeneratorRepository
{
    Task<List<Generator>> Get();
    Task<Guid> Create(Generator generator);
    Task<Guid> Delete(Guid generatorId);
    Task<Guid> Update(Guid generatorId, string key, string name,
          string description, string imageUrl);
}
