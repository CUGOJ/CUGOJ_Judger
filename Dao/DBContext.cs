using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
namespace CUGOJ.CUGOJ_Judger.Dao;

public class CaseContext : DbContext
{
    public DbSet<JudgeCase> JudgeCases { get; set; } = null!;
    public string DbPath { get; }
    public CaseContext()
    {
        DbPath = "./data/case.db";
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite($"Data Source={DbPath}");
    }
}

public class JudgeCaseProperties
{
    //TODO 补全评测用例属性
}

public class JudgeCase
{
    public long Id { get; set; }
    public long ProblemID { get; set; }
    public string Path { get; set; } = string.Empty;
    [MaxLength(1024)]
    public string Properties { get; set; } = string.Empty;
    public string MD5 { get; set; } = string.Empty;
    public int TimeLimit { get; set; }
    //TODO 补全评测用例属性
}