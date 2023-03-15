using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public class RecruitingDbContext: DbContext
{
    public RecruitingDbContext(DbContextOptions<RecruitingDbContext> options): base(options)
    {
        
    }
    
    // DbSets are properties of DbContex

    public DbSet<Job> Jobs { get; set; }
}