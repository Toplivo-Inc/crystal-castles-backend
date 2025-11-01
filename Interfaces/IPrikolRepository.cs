
using CrystalCastlesBackend.Models;

namespace CrystalCastlesBackend.Interfaces
{
  public interface IPrikolRepository
  {
    Task<Guid> Add(Prikol prikol);
    Task<Guid> Delete(Guid prikolId);
    Task<List<Prikol>> Get();
    Task<Guid> Update(Guid prikolId, string imageUrl, string description, PrikolStatusEnum status, string banMessage, Guid userId, Guid generatorId, DateTime createdAt, DateTime bannedAt);
  }
}
