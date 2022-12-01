using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transporte
{
    internal class Prestadores
    {

        public Queue<Prestador> ListaPrestadores = new Queue<Prestador>();


        public bool addPrestador(Prestador prestador)
        {

            ListaPrestadores.Enqueue(prestador);
            return true;

        }
    }
}
