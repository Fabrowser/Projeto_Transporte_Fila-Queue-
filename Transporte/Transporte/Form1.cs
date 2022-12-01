namespace Transporte
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        Passageiros passageiros = new Passageiros();
        Prestadores prestadores = new Prestadores();
        Viagens viagens = new Viagens();
        Veiculos veiculos = new Veiculos();
        Veiculo veiculo = new Veiculo();

        private void button1_Click(object sender, EventArgs e)
        {
            

            passageiros.addPassageiro(new Passageiro(1, "Fabricio", DateTime.Now));
            passageiros.addPassageiro(new Passageiro(2, "Alysson", DateTime.Now));
            passageiros.addPassageiro(new Passageiro(3, "Amanda", DateTime.Now));
            passageiros.addPassageiro(new Passageiro(4, "Fabio", DateTime.Now));
            MessageBox.Show("Passageiro adicionado com sucesso!");
            MessageBox.Show($"Quantidade de passageiros:{passageiros.ListaPassageiros.Count} ");
            atualizaListaPassageirosAguardando();
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {


            prestadores.addPrestador(new Prestador(1, "Tereza"));
            prestadores.addPrestador(new Prestador(2, "Tereza"));
            prestadores.addPrestador(new Prestador(3, "Tereza"));
            prestadores.addPrestador(new Prestador(4, "Tereza"));
            MessageBox.Show("Prestador adicionado com sucesso!");
            MessageBox.Show($"Quantidade de prestadores:{prestadores.ListaPrestadores.Count}");


        }

        private void button2_Click(object sender, EventArgs e)
        {
                  Veiculo veiculo_encontrato = veiculos.ListaVeiculos.FirstOrDefault();

                    Console.WriteLine("veiculo encontrato: " + veiculo_encontrato);

                if (veiculo.podeEmbarcarPassageiros(veiculo_encontrato,passageiros.ListaPassageiros.Count))
                {
                    Queue<Passageiro> lista_proximo_embarque = new Queue<Passageiro>(passageiros.listaProximaViagem(veiculo_encontrato.QuantidadePassageiros));
                    MessageBox.Show("RECEM ADICIONADO A LISTA DE EMBARQUE: " + lista_proximo_embarque.Count);

                    int cod_viagem = int.Parse(textBox4.Text);
                    int cod_prestador = int.Parse(textBox5.Text);
                    int cod_veiculo = veiculo_encontrato.CodVeiculo;
                    DateTime data_viagem = Convert.ToDateTime(textBox3.Text);

                    //Adiciona a viagem à lista de viagens
                    viagens.addViagem(new Viagem(cod_viagem, cod_veiculo, cod_prestador, data_viagem));
                    MessageBox.Show("Viagem adicionada com sucesso!");

                    //Retira passageiros da lista de passageiros aguardando
                    passageiros.embarcaPassageiro(lista_proximo_embarque.Count);

                    //Veiculo faz a viagem e volta ao final da fila
                   

                    veiculos.DespachaVeiculo();
                    veiculos.addVeiculo(veiculo_encontrato);
                    MessageBox.Show("Veiculo sai e volta ao fim da lista: " + veiculo_encontrato);



                    MessageBox.Show($"Quantidade de passageiros aguardando:{passageiros.ListaPassageiros.Count}");
                    atualizaListaPassageirosAguardando();



                }

            }


        private void atualizaListaPassageirosAguardando()
        {
            listBox1.Items.Clear();
            foreach (Passageiro p in passageiros.ListaPassageiros)
            {
                listBox1.Items.Add("Nome: " + p.NomeVisitante + "Data: " + p.DataVisita + "Hora: " + p.DataVisita.Hour);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            veiculos.addVeiculo(new Veiculo(1,"DYE-4457","Celta 4 portas","Fabricio",6));
            veiculos.addVeiculo(new Veiculo(2, "WWW-4457", "Gol 4 portas", "Antonio", 10));
            veiculos.addVeiculo(new Veiculo(3, "BBB-4457", "VAN 4 portas", "Lula", 15));
            veiculos.addVeiculo(new Veiculo(4, "GGG-4457", "Busão", "Bolsonaro", 20));
            MessageBox.Show("Veículo adicionado com sucesso!");
            MessageBox.Show($"Quantidade de veiculos:{veiculos.ListaVeiculos.Count}");

        }



    }
}