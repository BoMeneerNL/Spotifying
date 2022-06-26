namespace Spotifying.Interfaces
{
    internal interface IPlayable
    {
        void Play();
        void Pause();
        void Next();
        void Stop();
        int Length { get; set; }
    }
}
