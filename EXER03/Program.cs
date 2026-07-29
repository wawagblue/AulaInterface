using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXER03
{

    class Program
    {
        static void Main()
        {
            IReprodutorMultimidia player = new PlayerVideo();

            player.Play();
            player.Avancar(30);
            player.Pause();
            player.Stop();
        }
    }
}
