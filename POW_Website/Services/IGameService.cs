using POWStudio.Models;

namespace POWStudio.Services;

public interface IGameService
{
    Game? GetBySlug(string slug);
    List<Game?> GetAll();
}