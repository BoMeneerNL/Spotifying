using System.Collections.Generic;

namespace Spotifying.Classes
{
    public class Artist
    {
        string Naam { get; set; }
        List<Album> Albums { get; set; }
        List<Song> Songs { get; set; }
        public Artist(string naam, List<Album> albums)
        {
            Naam = naam;
            Albums = albums;
        }
        public void AddSong(Song song) => Songs.Add(song);
        public void AddAlbum(Album album) => Albums.Add(album);
        public override string ToString() => $"Naam: {Naam}, Albums: {Albums.Count}, Songs: {Songs.Count}";
    }
}
