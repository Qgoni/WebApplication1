using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;


namespace WebApplication1;
public class DBpdf : DbContext
{
  public DBpdf(DbContextOptions<DBpdf> options)
    : base(options)
  { }
  public DbSet<Files> Files { get; set; } = null!;

  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
  {
    optionsBuilder.UseSqlServer(@"Server = DESKTOP-0I5TVMN\SQLEXPRESS;Database = FileAddDB;Trusted_Connection=True");
  }             
}