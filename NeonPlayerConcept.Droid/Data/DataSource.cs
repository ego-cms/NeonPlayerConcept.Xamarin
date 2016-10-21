using System.Collections.Generic;

namespace NeonPlayerConcept.Droid.Data
{
    public class DataSource
    {
        public static List<Song> SongsQueue;
        public static List<Song> FavouriteSongs;

        static DataSource()
        {
            SongsQueue = new List<Song>
            {
                new Song { Title = "Boys Boys Boys", Artist = "Lady Gaga", CoverImageName = "gaga" },
                new Song { Title = "Roar", Artist = "Katy Perry", CoverImageName = "kp" },
                new Song { Title = "Supertrooper", Artist = "ABBA", CoverImageName = "abba" },
                new Song { Title = "Genie in a bottle", Artist = "Christina Aguilera", CoverImageName = "aguilera1" },
                new Song { Title = "J'en ai marre!", Artist = "Alizee", CoverImageName = "alizee2" },
                new Song { Title = "Treasure", Artist = "Bruno Mars", CoverImageName = "bm1" },
                new Song { Title = "Oops... I did it again!", Artist = "Britney Spears", CoverImageName = "britney1" },
                new Song { Title = "Boom Boom Pow", Artist = "Black Eyed Peas", CoverImageName = "byp1" },
                new Song { Title = "Clubbers Collection", Artist = "EDM", CoverImageName = "edm" },
                new Song { Title = "Fergalicious", Artist = "Fergie", CoverImageName = "fergie" }
            };

            FavouriteSongs = new List<Song>
            {
                new Song { Title = "Gentleman", Artist = "Psy", CoverImageName = "psy1" },
                new Song { Title = "Perfect Geometry", Artist = "Keane", CoverImageName = "keane" },
                new Song { Title = "Hidden Pictures", Artist = "Choosing Sides", CoverImageName = "hp" },
                new Song { Title = "Main Theme", Artist = "Grand Theft Auto V", CoverImageName = "gta" },
                new Song { Title = "Candyman", Artist = "Christina Aguilera", CoverImageName = "aguilera2" },
                new Song { Title = "La Isla Bonita", Artist = "Alizee", CoverImageName = "alizee2" },
                new Song { Title = "Dance Monkey", Artist = "Psy", CoverImageName = "psy3" },
                new Song { Title = "Grenade", Artist = "Bruno Mars", CoverImageName = "bm2" },
                new Song { Title = "The Way I Are", Artist = "Timbaland", CoverImageName = "tbland2" },
                new Song { Title = "Womanizer", Artist = "Britney Spears", CoverImageName = "britney3" },
                new Song { Title = "My Humps", Artist = "Black Eyed Peas", CoverImageName = "byp1" },
                new Song { Title = "Uptown Funk", Artist = "Bruno Mars", CoverImageName = "bm3" },
                new Song { Title = "SexyBack", Artist = "Justin Timberlake", CoverImageName = "tbl1" },
                new Song { Title = "Toxic", Artist = "Britney Spears", CoverImageName = "britney2" },
                new Song { Title = "Gangnam Style", Artist = "Psy", CoverImageName = "psy2" },
                new Song { Title = "Shake It Off", Artist = "Tailor Swift", CoverImageName = "swift" },
                new Song { Title = "Young Girls", Artist = "Bruno Mars", CoverImageName = "bm4" },
                new Song { Title = "Give It To Me", Artist = "Timbaland", CoverImageName = "tbland1" },
                new Song { Title = "Gimme Gimme More", Artist = "Britney Spears", CoverImageName = "britney4" },
                new Song { Title = "Marry You", Artist = "Bruno Mars", CoverImageName = "bm5" },
                new Song { Title = "Cry Me a River", Artist = "Justin Timberlake", CoverImageName = "tbl2" },
                new Song { Title = "Hey! Amigo!", Artist = "Alizee", CoverImageName = "alizee1" }
            };
        }
    }
}

