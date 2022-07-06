using Spotifying.Interfaces;
using System;
using System.Collections.Generic;

namespace Spotifying.Classes
{
    internal class Client
    {
        private IPlayable CurrentlyPlaying { get; set; }
        private long CurrentTime { get; set; }
        private bool Playing { get; set; }
        private bool Shuffle { get; set; }
        private bool Repeat { get; set; }
        public static Person ActiveUser;
        public static List<Person> Users { get; set; } = new();
        public static List<Album> Albums { get; set; } = new();
        public static List<Song> Songs { get; set; } = new();
        public static List<Playlist> Playlists = new();
        public void SetShuffle(bool a) => Shuffle = a;
        public void SetRepeat(bool a) => Repeat = a;
        public void ShowAllAlbums() => Albums.ForEach(x => Console.WriteLine(x));
        public void ShowAllUsers() => Users.ForEach(x => Console.WriteLine(x.GetNaam()));
        public Person GetActiveUser() => ActiveUser;
        public void ShowAllSongs()
        {
            foreach (var album in Albums)
                foreach (var item in album.items)
                    Console.WriteLine(item);
        }
        public Song SelectSong(int index)
        {
            List<Song> songs = new();
            foreach(Song song in Songs)
            {
                songs.Add(song);
            }
            if (index < songs.Count)
                return songs[index];
            Console.WriteLine("Could not select song because the index is out of range");
            return new();
        }
        public Person SelectUser(int index)
        {
            if (index < Users.Count)
                return Users[index];
            Console.WriteLine("Could not select user because the index is out of range");
            return new("");
        }
        public void SetActiveUser(Person person)
        {
            if (Users.Contains(person))
                ActiveUser = person;
            else
                Console.WriteLine("Could not add the user as current user because it is not in the users list");
        }
        public Album SelectAlbum(int index)
        {
            if (index < Albums.Count)
                return Albums[index];

            Console.WriteLine("Could not select album because the index is out of range");
            return new();
        }
        public Client(List<Person> users,List<Album> albums, List<Song> songs)
        {
            Users = users;
            Albums = albums;
            Songs = songs;
        }
        public void SetCurrentlyPlaying(IPlayable item) =>CurrentlyPlaying = item;
        public IPlayable GetCurrentlyPlaying() => CurrentlyPlaying;
        public void ShowUserPlaylists()=> Playlists.ForEach(x => {if (x.Owner == ActiveUser) Console.WriteLine(x.Naam);});
        public Playlist SelectUserPlaylist(int index)
        {
            List<Playlist> Playlists = new();
            Playlists.ForEach(x=> {
                if (x.Owner == ActiveUser)
                    Playlists.Add(x);
            });
            index--;
            if (index < Playlists.Count)
                return Playlists[index];
            Console.WriteLine("Could not select playlist because the index is out of range");
            return new("");
        }
        public void Play() => CurrentlyPlaying.Play();
        public void Pause() => CurrentlyPlaying.Pause();
        public void Stop() => CurrentlyPlaying.Stop();
        public void NextSong() => CurrentlyPlaying.Next();
        public void CreatePlaylist(string naam) => Playlists.Add(new Playlist(ActiveUser,naam));

    }
}