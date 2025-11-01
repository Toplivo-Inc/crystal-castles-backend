using CrystalCastlesBackend.Models;


namespace CrystalCastlesBackend.Interfaces
{
  public interface IPrikolLikeRepository
  {
    Task<Guid> Add(PrikolLike prikolLike);
    Task<Guid> Delete(Guid prikolLikeId);
    Task<List<PrikolLike>> Get();
    Task<Guid> Update(Guid prikolLikeId, Guid userId, Guid prikolId, DateTime createdAt);
  }
}
