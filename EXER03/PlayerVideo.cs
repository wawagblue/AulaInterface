using System;

namespace EXER03
{
    public class PlayerVideo : IReprodutorMultimidia
    {
        public void Play()
        {
            Console.WriteLine("Vídeo reproduzindo.");
        }

        public void Pause()
        {
            Console.WriteLine("Vídeo pausado.");
        }

        public void Stop()
        {
            Console.WriteLine("Vídeo parado.");
        }

        public void Avancar(int segundos)
        {
            Console.WriteLine($"Vídeo avançou {segundos} segundos.");
        }
    }
}
