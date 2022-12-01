using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transporte
{
    internal class Viagem
    {
        public int CodViagem { get; set; }
        public int Codprestador { get; set; }
        public int CodVeiculo { get; set; }
        public DateTime DataViagem { get; set; }
        public Queue<Passageiro> ListaPassageiros{ get; set; }

        public Viagem(int codViagem, int codprestador, int codVeiculo, DateTime dataViagem)
        {

            CodViagem = codViagem;
            Codprestador = codprestador;
            CodVeiculo = codVeiculo;
            DataViagem = dataViagem;
        }
       
    }

    
}
