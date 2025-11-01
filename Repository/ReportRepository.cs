using CrystalCastlesBackend.Models;
using Microsoft.EntityFrameworkCore;
using CrystalCastlesBackend.Interfaces;

namespace CrystalCastlesBackend.Repository
{


  public class ReportRepository : IReportRepository
  {

    private CastlesDbContext _dbContext;
    public ReportRepository(CastlesDbContext dbContext)
    {
      _dbContext = dbContext;
    }

    public async Task<List<Report>> Get()
    {
      var reports = await _dbContext.Reports
        .AsNoTracking()
        .ToListAsync();

      return reports;
    }

    public async Task<Guid> Add(Report report)
    {
      var reportEntity = new Report
      {
        ReportId = report.ReportId,
        Title = report.Title,
        Description = report.Description,
        IsProcessed = report.IsProcessed,
        PrikolId = report.PrikolId,
        UserId = report.UserId
      };
      await _dbContext.AddAsync(reportEntity);
      await _dbContext.SaveChangesAsync();

      return reportEntity.ReportId;
    }

    public async Task<Guid> Delete(Guid reportId)
    {
      await _dbContext.Reports.Where(r => r.ReportId == reportId)
        .ExecuteDeleteAsync();

      return reportId;
    }

    public async Task<Guid> Update(Guid reportId, string title, bool isProcessed, Guid prikolId, Guid userId)
    {
      await _dbContext.Reports.Where(i => i.ReportId == reportId)
        .ExecuteUpdateAsync(s => s
            .SetProperty(u => u.ReportId, u => reportId)
            .SetProperty(u => u.Title, u => title)
            .SetProperty(u => u.IsProcessed, u => isProcessed)
            .SetProperty(u => u.PrikolId, u => prikolId)
            .SetProperty(u => u.UserId, u => userId));

      return reportId;
    }

  }
}
