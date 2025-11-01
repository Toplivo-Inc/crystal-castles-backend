using CrystalCastlesBackend.Models;
using System.Text.Json;

namespace CrystalCastlesBackend.Interfaces
{
  public interface IPrikolcGenerationTransitionRepository
  {
    Task<Guid> Add(PrikolGenerationTransition prikolGenerationTransition);
    Task<Guid> Delete(Guid prikolGenerationTransitionId);
    Task<List<PrikolGenerationTransition>> Get();
    Task<Guid> Update(Guid prikolGenerationTransitionId, Guid prikolId, DateTime transitionTimestamp, Guid userId, PrikolGenerationStatusEnum newState, JsonDocument payload, Guid previousTransitionId);
  }
}
