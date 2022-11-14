using WebApplication1.Models;

namespace WebApplication1.Service.Interfaces;

public interface IFilesRepository : IBaseRepository<Files>
{
    Task<Files> GetByName(string name);
}