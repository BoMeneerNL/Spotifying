using System.Collections.Generic;

namespace Spotifying.Classes
{
    public class Album : SongCollection
    {
        public List<Artist> Artists { get; set; } = new();
        public override string ToString() => $"Albumnaam: {Naam}";
        public Album(List<Artist> artists, List<Song> songs, string naam)
        {
            Naam = naam;
            Songs = songs;
            Artists = artists;
        }

        public Album() {}
    }
}
