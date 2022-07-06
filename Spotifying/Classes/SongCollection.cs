using System.Collections.Generic;

namespace Spotifying.Classes
{
    public class SongCollection
    {
        public string Naam { get; set; }
        public List<Song> Songs { get; set; }
        public void AddSong(Song song) => Songs.Add(song);
        public void RemoveSong(Song song) => Songs.RemoveAll(x => x == song);
        public void ShowAllSongs() => Songs.ForEach(x => x.ToString());
        public override string ToString() => $"Naam: {Naam}, Songs {Songs.Count}";
    }
}
