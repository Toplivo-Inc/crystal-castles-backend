using System.Text.Json;
using CrystalCastlesBackend.Models;

namespace CrystalCastlesBackend.Interfaces
{
  public interface IPrikolTransitionRepository
  {
    Task<Guid> Add(PrikolTransition prikolTransition);
    Task<Guid> Delete(Guid prikolTransitionId);
    Task<List<PrikolTransition>> Get();
    Task<Guid> Update(Guid prikolTransitionId, Guid prikolId, DateTime transitionTimestamp, Guid userId, PrikolStatusEnum newState, JsonDocument payload, Guid previousTransitionId);
  }
}
