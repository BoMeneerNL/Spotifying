using System.Collections.Generic;

namespace Spotifying.Classes
{
    internal class Artist
    {
        string Naam { get; set; }
        List<Album> Albums { get; set; }
        List<Song> Songs { get; set; }
    }
}
