using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transporte
{
    internal class Veiculo
    {
        public int CodVeiculo { get; set; }
        public String PlacaVeiculo { get; set; }
        public String DescricaoVeiculo { get; set; }
        public String NomeMotorista { get; set; }
        public int QuantidadePassageiros { get; set; }

        public Veiculo()
        {
        }

        public Veiculo(int codVeiculo, string placaVeiculo, string descricaoVeiculo, string nomeMotorista, int quantidadePassageiros)
        {
            CodVeiculo = codVeiculo;
            PlacaVeiculo = placaVeiculo;
            DescricaoVeiculo = descricaoVeiculo;
            NomeMotorista = nomeMotorista;
            QuantidadePassageiros = quantidadePassageiros;

        }



        public bool podeEmbarcarPassageiros(Veiculo v, int numero_passageiros)
        {

            if (v.QuantidadePassageiros <= numero_passageiros)
            {
                
                return true;

            }
            else
            {
                MessageBox.Show("Aguardar mais passageiros para preencher o próximo carro!\n" +
                    "Quantidade de Vagas no carro: " + v.QuantidadePassageiros + "\n" +
                    "Quantidade de Passageiros: " + numero_passageiros);
                return false;
            }

        }

        public override string ToString()
        {
            return "PLACA: " + PlacaVeiculo +
               "\nMODELO: " + DescricaoVeiculo + 
               "\nMotorista: " + NomeMotorista;
        }
    }
}
