using EVSResultsApi.Models;
using Microsoft.EntityFrameworkCore;

namespace EVSResultsApi.DataAccess
{
    public interface ISQLiteDBContext
    {
        DbSet<Group> Groups { get; set; }
        DbSet<Pitch> Pitches { get; set; }
        DbSet<Team> Teams { get; set; }
        int SaveChanges();
    }
}
