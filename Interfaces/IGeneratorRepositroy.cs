using CrystalCastlesBackend.Models;

namespace CrystalCastlesBackend.Interfaces
{

  public interface IGeneratorRepository
  {
    Task<Guid> Add(Generator generator);
    Task<Guid> Delete(Guid generatorId);
    Task<List<Generator>> Get();
    Task<Guid> Update(Guid generatorId, string key, string name, string description, string imageUrl);
  }
}
