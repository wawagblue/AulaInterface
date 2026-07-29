using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXER5
{
    class Program
    {
        static void Main()
        {
            ITransporte transporte = new Aviao();

            transporte.IniciarViagem("São Paulo");
            transporte.FinalizarViagem();
        }
    }
}
