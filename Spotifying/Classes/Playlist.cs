namespace Spotifying.Classes
{
    public class Playlist : SongCollection
    {
        public Person Owner { get; set; }
        public Playlist(string naam)
        {
            Owner = Client.ActiveUser;
            Naam = naam;
            Client.Playlists.Add(this);
        }
        public Playlist(Person owner, string naam)
        {
            Owner = owner;
            Naam = naam;
            Client.Playlists.Add(this);
        }
        public override string ToString() => $"Naam: {Naam} Eigenaar: {Owner}";
        
    }
}
