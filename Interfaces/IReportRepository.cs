
using CrystalCastlesBackend.Models;

namespace CrystalCastlesBackend.Interfaces
{
  public interface IReportRepository
  {
    Task<Guid> Add(Report report);
    Task<Guid> Delete(Guid reportId);
    Task<List<Report>> Get();
    Task<Guid> Update(Guid reportId, string title, bool isProcessed, Guid prikolId, Guid userId);
  }
}
