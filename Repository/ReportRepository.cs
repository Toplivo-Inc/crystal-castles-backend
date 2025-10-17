using CrystalCastlesBackend.Models;
using Microsoft.EntityFrameworkCore;

public class ReportRepository
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

    public async Task<Guid> Add()
    {
      
    }

    public async Task<Guid> Delete(Guid reportId)
    {
      await _dbContext.Reports.Where(r =>r.ReportId == reportId)
        .ExecuteDeleteAsync();
      
      return reportId; 
    }

    public async Task<Guid> Update()
    {

    }

}
