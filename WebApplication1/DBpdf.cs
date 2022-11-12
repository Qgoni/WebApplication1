using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;
using DbContext = System.Data.Entity.DbContext;

namespace WebApplication1;

public class DBpdf : DbContext
{
  public DBpdf(DbContextOptions<DBpdf> options)
    : base(options)
  {
  }

  public System.Data.Entity.DbSet<Files> Files { get; set; }

  protected override void OnConfiguiring(DbContextOptionsBuilder optionsBuilder)
  {
    optionsBuilder.UseSqlServer(@"DESKTOP-0I5TVMN\SQLEXPRESS");

  }
}