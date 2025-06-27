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
            bPublic = false,
            Title = "Bedoso Monster",
            Slug = "bedoso-monster",
            ShortDescription = "Where peace once lived, monsters now rule",
            DetailedDescription = "Enter Bedoso Monster, a tense third-person shooter where you will face the nameless horrors lurking in the deserted town of Bedoso. After a mysterious event, this once peaceful town is now plunged into darkness and taken over by hideous monsters of unknown origin.",
            TittleImageUrl = "/Image/Logo/BedosoMonsterTitleWhite.png",
            BgImageUrl = "/Image/ArtworkGame/BedosoMonsterBG.jpg",
            SteamUrl = "https://store.steampowered.com/app/bedoso-monster",
            ItchioUrl = "https://powstudio.itch.io/bedoso-monster",
            EpicUrl = "https://store.epicgames.com/en-US/p/bedoso-monster",
            TrailerUrl = "https://www.youtube.com/embed/hHyBYI8EF-c?si=WrwJn6gHF1ZI4MUF",
        },
        new Game
        {
            Title = "Horror Serum",
            Slug = "horrorserum",
            TittleImageUrl = "/Image/Logo/HorrorSerumTitle.png",
            ShortDescription = "It promised power. It delivered torment.",
            BgImageUrl = "/Image/ArtworkGame/HorrorSerumArtwork.jpg",
            ItchioUrl = "https://powstudio.itch.io/horrorserum",
            DetailedDescription = "Horror Serum, you will experience the horror from a first-person perspective, discovering a dark story surrounding a mysterious serum. This solution promises extraordinary power, but the price to pay may be beyond imagination.",
            TrailerUrl = "https://www.youtube.com/embed/y8PKcCArLQ0?si=AyBEMqYDRoU6cIVM"
        },
        new Game
        {
            Title = "Bad Of Greenthorn",
            Slug = "bad-of-greenthorn",
            TittleImageUrl = "/Image/Logo/BadOfGreenThornTitleWhite.png",
            ShortDescription = "A fallen mage. A cursed land. One last hope.",//Strike down darkness. Save the kingdom.
            BgImageUrl = "/Image/ArtworkGame/BadOfGreenThorn capture.jpg",
            ItchioUrl = "https://powstudio.itch.io/bad-of-greenthorn",
            DetailedDescription = "Bad of Greenthorn is a 2D hack and slash action platformer that takes you on a thrilling adventure! As the hero of the kingdom, you will embark on a dangerous journey to destroy the treacherous mage Greenthorn - who has spread chaos and darkness everywhere.",
            TrailerUrl = "https://www.youtube.com/embed/UOMMnQUUchM?si=PcooWto9nK3Z7dLe"
        },
        new Game
        {
            Title = "Interactive Paper",
            Slug = "interactive-paper",
            ShortDescription = "Tool for interactive paper game.",
            BgImageUrl = "/Image/ArtworkGame/PaperInteractive16div9.png",
            ItchioUrl = "https://powstudio.itch.io/interactive-paper-effect-ue",
            FabUrl = "https://fab.com/s/96b6838c5448",
            TrailerUrl = "https://www.youtube.com/embed/aoogGi-WoGo?si=IsxShWRyt3uTv8Kb"
        }
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