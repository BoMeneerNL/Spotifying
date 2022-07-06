using Spotifying.Interfaces;
using System;
using System.Collections.Generic;

namespace Spotifying.Classes
{
    public class Song : IPlayable
    {
        public List<Artist> Artiesten { get; set; }
        public int Lengte { get; set; }
        public string Naam { get; set; }
        public void Play() => Console.WriteLine("Playing: " + Naam);
        public void Pause() => Console.WriteLine("Pausing: " + Naam);
        public void Stop() => Console.WriteLine("Stopping: " + Naam);
        public void Next() => Play();
        public Song(List<Artist> artiesten, string naam, int lengte)
        {
            Artiesten = artiesten;
            Naam = naam;
            Lengte = lengte;
        }

        public Song()
        {
        }

        public override string ToString() => $"name: {Naam} - {Artiesten}, length: {Lengte}";
    }
}
