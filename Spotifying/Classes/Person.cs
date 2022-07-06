using System;
using System.Collections.Generic;

namespace Spotifying.Classes
{
    public class Person
    {
        string Naam { get; set; }
        List<Person> Friends { get; set; } = new();
        List<Playlist> Playlists { get; set; } = new();
        public Person(string naam) => Naam = naam;
        public string GetNaam() => Naam;
        public void AddFriend(Person person) => Friends.Add(person);
        public void RemoveFriend(Person person) => Friends.RemoveAll(x => x == person);
        public void ShowFriends() => Friends.ForEach(x => Console.WriteLine(x.GetNaam()));
        public void ShowPlaylists() => Playlists.ForEach(x => Console.WriteLine(x.ToString()));
        public Playlist CreatePlaylist(string naam) => new(naam);
        public void RemovePlaylist(Playlist playlist) => Playlists.RemoveAll(x => x == playlist);
        public void AddToPlaylist(Playlist playlist, Song song) => playlist.AddSong(song);
        public void RemoveFromPlaylist(Playlist playlist, Song song) => playlist.RemoveSong(song);
        public override string ToString() => $"Name: {Naam}, Friends: {Friends.Count}, Playlists: {Playlists.Count}";
        public Playlist SelectPlaylist(int index)
        {
            index = index--;
            if (index < Playlists.Count)
                return Playlists[index];

            Console.WriteLine("Could not select playlist because the index is out of range");
            return new("");
        }
    }
}
