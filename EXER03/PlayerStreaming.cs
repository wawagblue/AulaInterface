using System;

namespace EXER03
{
    public class PlayerStreaming : IReprodutorMultimidia
    {
        public void Play()
        {
            Console.WriteLine("Streaming iniciado.");
        }

        public void Pause()
        {
            Console.WriteLine("Streaming pausado.");
        }

        public void Stop()
        {
            Console.WriteLine("Streaming encerrado.");
        }

        public void Avancar(int segundos)
        {
            Console.WriteLine($"Streaming avançou {segundos} segundos.");
        }
    }
}
