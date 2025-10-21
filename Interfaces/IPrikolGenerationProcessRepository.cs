using CrystalCastlesBackend.Models;

public interface IPrikolGenerationProcessRepository
{
    Task<List<PrikolGenerationProcess>> Get();
    Task<Guid> Create(PrikolGenerationProcess prikolGenerationProcess);
    Task<Guid> Delete(Guid prikolId);
    Task<Guid> Update();
}
