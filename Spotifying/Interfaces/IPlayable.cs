namespace Spotifying.Interfaces
{
    public interface IPlayable
    {
        void Play();
        void Pause();
        void Next();
        void Stop();
        int Lengte { get; set; }
    }
}
