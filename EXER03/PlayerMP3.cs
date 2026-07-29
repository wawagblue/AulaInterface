using System;

namespace EXER03
{
    public class PlayerMP3 : IReprodutorMultimidia
    {
        public void Play()
        {
            Console.WriteLine("MP3 reproduzindo música.");
        }

        public void Pause()
        {
            Console.WriteLine("MP3 pausado.");
        }

        public void Stop()
        {
            Console.WriteLine("MP3 parado.");
        }

        public void Avancar(int segundos)
        {
            Console.WriteLine($"MP3 avançou {segundos} segundos.");
        }
    }
}
