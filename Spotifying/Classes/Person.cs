using System;
using System.Collections.Generic;

namespace Spotifying.Classes
{
    internal class Person
    {
        string Naam { get; set; }
        List<Person> Friends { get; set; }
        List<Playlist> Playlists { get; set; }
        public string GetNaam()=>Naam;
        public void ShowFriends()
        {
         for(int i =0; ;i++)
                Console.WriteLine(Friends[i].GetNaam());
        }
        public void ShowPlaylists()
        {
        }
    }
}
