using System.Collections.Generic;

namespace NeonPlayerConcept.iOS.Data
{
    public class DataSource
    {
        public static List<Song> SongsQueue;
        public static List<Song> FavouriteSongs;

        static DataSource()
        {
            SongsQueue = new List<Song>
            {
                new Song { Title = "Boys Boys Boys", Artist = "Lady Gaga", CoverImageName = "Gaga" },
                new Song { Title = "Roar", Artist = "Katy Perry", CoverImageName = "Kp" },
                new Song { Title = "Supertrooper", Artist = "ABBA", CoverImageName = "Abba" },
                new Song { Title = "Genie in a bottle", Artist = "Christina Aguilera", CoverImageName = "Aguilera1" },
                new Song { Title = "J'en ai marre!", Artist = "Alizee", CoverImageName = "Alizee2" },
                new Song { Title = "Treasure", Artist = "Bruno Mars", CoverImageName = "Bm1" },
                new Song { Title = "Oops... I did it again!", Artist = "Britney Spears", CoverImageName = "Britney1" },
                new Song { Title = "Boom Boom Pow", Artist = "Black Eyed Peas", CoverImageName = "Byp1" },
                new Song { Title = "Clubbers Collection", Artist = "EDM", CoverImageName = "Edm" },
                new Song { Title = "Fergalicious", Artist = "Fergie", CoverImageName = "Fergie" }
            };

            FavouriteSongs = new List<Song>
            {
                new Song { Title = "Gentleman", Artist = "Psy", CoverImageName = "Psy1" },
                new Song { Title = "Perfect Geometry", Artist = "Keane", CoverImageName = "Keane" },
                new Song { Title = "Hidden Pictures", Artist = "Choosing Sides", CoverImageName = "Hp" },
                new Song { Title = "Main Theme", Artist = "Grand Theft Auto V", CoverImageName = "Gta" },
                new Song { Title = "Candyman", Artist = "Christina Aguilera", CoverImageName = "Aguilera2" },
                new Song { Title = "La Isla Bonita", Artist = "Alizee", CoverImageName = "Alizee2" },
                new Song { Title = "Dance Monkey", Artist = "Psy", CoverImageName = "Psy3" },
                new Song { Title = "Grenade", Artist = "Bruno Mars", CoverImageName = "Bm2" },
                new Song { Title = "The Way I Are", Artist = "Timbaland", CoverImageName = "Tbland2" },
                new Song { Title = "Womanizer", Artist = "Britney Spears", CoverImageName = "Britney3" },
                new Song { Title = "My Humps", Artist = "Black Eyed Peas", CoverImageName = "Byp1" },
                new Song { Title = "Uptown Funk", Artist = "Bruno Mars", CoverImageName = "Bm3" },
                new Song { Title = "SexyBack", Artist = "Justin Timberlake", CoverImageName = "Tbl1" },
                new Song { Title = "Toxic", Artist = "Britney Spears", CoverImageName = "Britney2" },
                new Song { Title = "Gangnam Style", Artist = "Psy", CoverImageName = "Psy2" },
                new Song { Title = "Shake It Off", Artist = "Tailor Swift", CoverImageName = "Swift" },
                new Song { Title = "Young Girls", Artist = "Bruno Mars", CoverImageName = "Bm4" },
                new Song { Title = "Give It To Me", Artist = "Timbaland", CoverImageName = "Tbland1" },
                new Song { Title = "Gimme Gimme More", Artist = "Britney Spears", CoverImageName = "Britney4" },
                new Song { Title = "Marry You", Artist = "Bruno Mars", CoverImageName = "Bm5" },
                new Song { Title = "Cry Me a River", Artist = "Justin Timberlake", CoverImageName = "Tbl2" },
                new Song { Title = "Hey! Amigo!", Artist = "Alizee", CoverImageName = "Alizee1" }
            };
        }
    }
}

