using CrystalCastlesBackend.Models;

namespace CrystalCastlesBackend.Interfaces
{
  public interface IPrikolGenerationProcessRepository
  {
    Task<Guid> Add(PrikolGenerationProcess prikolGenerationProces);
    Task<Guid> Delete(Guid prikolId);
    Task<List<PrikolGenerationProcess>> Get();
    Task<Guid> Update(Guid prikolId, PrikolGenerationStatusEnum status, string errorMessage, DateTime createdAt, DateTime updatedAt);
  }
}
