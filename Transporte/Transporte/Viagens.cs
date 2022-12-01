using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transporte
{
    internal class Viagens
    {

        public Queue<Viagem> ListaDeViagens = new Queue<Viagem> ();
       



        public bool addViagem(Viagem viagem)
        {

            ListaDeViagens.Enqueue (viagem);
            return true;
        }

    }
}
