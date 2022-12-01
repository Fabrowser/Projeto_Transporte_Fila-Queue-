using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transporte
{
    internal class Passageiros
    {
        public Queue<Passageiro> ListaPassageiros = new Queue<Passageiro>();


        public bool addPassageiro(Passageiro passageiro)
        {

            ListaPassageiros.Enqueue(passageiro);
            return true;

        }

        public void embarcaPassageiro(int qtd)
        {
            int q = 0;
            for(int i = 0; i<qtd; i++)
            {

                ListaPassageiros.Dequeue();
                q++;

            }
            Console.WriteLine("Quantidade de Passageiros embarcados: " + q);

        }

        public Queue<Passageiro> listaProximaViagem(int qtd)
        {
            var lista = new Queue<Passageiro>();
            int i = 0;

            foreach (Passageiro passageiro in ListaPassageiros)
            {
                if (i < qtd)
                {
                    lista.Enqueue(passageiro);
                }

                i++;
             
            }
            return lista;
        }


        public Queue<Passageiro> atualizaPassageirosAguardando()
        {
            Queue<Passageiro> lista = new Queue<Passageiro>();

            foreach (Passageiro p in ListaPassageiros)
            {

                lista.Enqueue(p);

            }

            return lista;

        }

    }
}
