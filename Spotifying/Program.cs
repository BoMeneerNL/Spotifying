using Spotifying.Classes;
using System;

namespace Spotifying
{
    internal class Program
    {
        static void Main()
        {
            Client CurrentClient = new(new(),new(),new());
            Person Robert = new("Robert");
            Person John = new("John");
            Robert.AddFriend(John);
            CurrentClient.SetActiveUser(Robert);
            Robert.CreatePlaylist("Personal playlist");
            Robert.AddToPlaylist(Robert.SelectPlaylist(0),new Album(new(),new(), "Astrophysical"));
            Robert.AddToPlaylist(Robert.SelectPlaylist(0), new Song(new(), "Say to Me", 100));
            CurrentClient.SetCurrentlyPlaying(CurrentClient.SelectAlbum(0));
            CurrentClient.Play();

        }
    }
}
