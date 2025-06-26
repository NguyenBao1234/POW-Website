using POWStudio.Models;
namespace POWStudio.Services;
using System.Collections.Generic;
using System.Linq;


public class GameService : IGameService
{
    private List<Game?> gameList = new()
    {
        new Game
        {
            Title = "Bedoso Monster",
            Slug = "bedoso-monster",
            ShortDescription = "A dark survival horror game.",
            DetailedDescription = "Enter Bedoso Monster, a tense third-person shooter where you will face the nameless horrors lurking in the deserted town of Bedoso. After a mysterious event, this once peaceful town is now plunged into darkness and taken over by hideous monsters of unknown origin.",
            TittleImageUrl = "/Image/Logo/BedosoMonsterTitleWhite.png",
            BgImageUrl = "/Image/ArtworkGame/BedosoMonsterBG.jpg",
            SteamUrl = "https://store.steampowered.com/app/bedoso-monster",
            ItchioUrl = "https://powstudio.itch.io/bedoso-monster",
            EpicUrl = "https://store.epicgames.com/en-US/p/bedoso-monster",
            TrailerUrl = "https://youtu.be/109bOoM2hSwhttps://youtu.be/5N7U4Wx3CiM",
        },
        new Game
        {
            Title = "Horror Serum",
            Slug = "horrorserum",
            TittleImageUrl = "/Image/Logo/HorrorSerumTitle.png",
            ShortDescription = "A dark survival horror game.",
            BgImageUrl = "/Image/ArtworkGame/HorrorSerumArtwork.jpg",
            ItchioUrl = "https://powstudio.itch.io/horrorserum",
            DetailedDescription = "Horror Serum, you will experience the horror from a first-person perspective, discovering a dark story surrounding a mysterious serum. This solution promises extraordinary power, but the price to pay may be beyond imagination."
        },
        new Game
        {
            Title = "Bad Of Greenthorn",
            Slug = "bad-of-greenthorn",
            TittleImageUrl = "/Image/Logo/BadOfGreenThornTitleWhite.png",
            ShortDescription = "Puzzle-based psychological thriller.",
            BgImageUrl = "/Image/ArtworkGame/BadOfGreenThorn capture.jpg",
            ItchioUrl = "https://powstudio.itch.io/bad-of-greenthorn",
            DetailedDescription = "Bad of Greenthorn is a 2D hack and slash action platformer that takes you on a thrilling adventure! As the hero of the kingdom, you will embark on a dangerous journey to destroy the treacherous mage Greenthorn - who has spread chaos and darkness everywhere."
        },
        new Game
        {
            Title = "Interactive Paper",
            Slug = "interactive-paper",
            ShortDescription = "Tool for interactive paper game.",
            BgImageUrl = "/Image/ArtworkGame/PaperInteractive16div9.png",
            ItchioUrl = "https://powstudio.itch.io/interactive-paper-effect-ue",
            FabUrl = "https://fab.com/s/96b6838c5448"
        }
        // Thêm game khác ở đây...
    };

    public Game? GetBySlug(string slug)
    {
        return gameList.FirstOrDefault(g => g.Slug.ToLower() == slug.ToLower());
    }

    public List<Game?> GetAll()
    {
        return gameList;
    }
}