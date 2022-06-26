using System;
using System.Collections.Generic;

namespace Spotifying.Classes
{
    internal class Client
    {
        private Interfaces.IPlayable CurrentlyPlaying { get; set; }
        private long CurrentTime { get; set; }
        private bool Playing { get; set; }
        private bool Shuffle { get; set; }
        private bool Repeat { get; set; }
        private Person ActiveUser { get; set; }
        public List<Person> Users { get; set; } = new();
        public List<Album> Albums { get; set; } = new();
        public Client(List<Person> users) => Users = users;
        public void SetShuffle() => Shuffle = !Shuffle;
        public void Set
        public void ShowAllAlbums()
        {

        }
        public void SetCurrentUser(Person person){
            if (Users.Contains(person))
                ActiveUser = person;
            else 
                Console.WriteLine("Could not add the user as current user because it is not in the users list");
        }
        public void ShowAllUsers()
        {
            for (int i = 0; i < Users.Count; i++)
            {
                Console.WriteLine(Users[i].GetNaam());
            }
        }
    }
}
