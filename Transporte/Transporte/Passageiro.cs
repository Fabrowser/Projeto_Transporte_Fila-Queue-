using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transporte
{
    internal class Passageiro
    {

        public int CodInscricao { get; set; }
        public int CodViagem { get; set; }
        public String NomeVisitante { get; set; }
        public DateTime DataVisita { get; set; }

        public Passageiro()
        {


        }

        public Passageiro(int codInscricao, string nomeVisitante, DateTime dataVisita)
        {
            CodInscricao = codInscricao;
            NomeVisitante = nomeVisitante;
            DataVisita = dataVisita;
        }


    }
}
