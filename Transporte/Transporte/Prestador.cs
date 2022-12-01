using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transporte
{
    internal class Prestador
    {
        public int CodPrestador { get; set; }
        public String NomePrestador { get; set; }


        public Prestador(int codPrestador, string nomePrestador)
        {
            CodPrestador = codPrestador;
            NomePrestador = nomePrestador;
        }
    }
}
