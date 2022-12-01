using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transporte
{
    internal class Veiculos
    {

        public Queue<Veiculo> ListaVeiculos = new Queue<Veiculo>();


        public bool addVeiculo(Veiculo veiculo)
        {

            ListaVeiculos.Enqueue(veiculo);
            return true;

        }

        public Veiculo existeVeiculo(int cod_veiculo)
        {

            foreach (Veiculo carro in ListaVeiculos)
            {
                if (carro.CodVeiculo == cod_veiculo)
                {
                    return carro;
                }
            }
            return null;
        }

        public void DespachaVeiculo()
        {
            ListaVeiculos.Dequeue();
        }


    }
}
