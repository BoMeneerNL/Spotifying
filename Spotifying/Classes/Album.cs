using Spotifying.Interfaces;
using System.Collections.Generic;

namespace Spotifying.Classes
{
    //IPlayable and it's interface content can be found in "SongCollection"
    public class Album : SongCollection
    {
        public List<Artist> Artists { get; set; } = new();

        public override string ToString() => $"Albumnaam: {Naam}, Nummers: {Songs.Count}";
        public Album(List<Artist> artists, List<Song> songs, string naam)
        {
            Naam = naam;
            Songs = songs;
            Artists = artists;
            Client.Albums.Add(this);
        }

        public Album() {}
    }
}
