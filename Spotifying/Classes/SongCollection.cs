using Spotifying.Interfaces;
using System;
using System.Collections.Generic;

namespace Spotifying.Classes
{
    public class SongCollection: IPlayable
    {
        public List<Song> Songs { get; set; } = new();
        public string Naam { get; set; }
        public List<IPlayable> items { get; set; } = new();
        public void Add(IPlayable item) => items.Add(item);
        public void Remove(IPlayable item) => items.RemoveAll(x => x == item);
        public void ShowAllPlayables() => items.ForEach(x => x.ToString());
        public void Play() => Console.WriteLine("Playing: " + Naam);
        public void Pause() => Console.WriteLine("Pausing: " + Naam);
        public void Stop() => Console.WriteLine("Stopping: " + Naam);
        public void Next() => Play();
        public int Lengte { get; set; }
        public override string ToString() => $"Naam: {Naam}, items {items.Count}";

    }
}
