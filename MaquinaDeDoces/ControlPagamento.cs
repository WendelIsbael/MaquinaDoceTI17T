using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaDeDoces
{
    class ControlPagamento
    {

        // Declarando as variaveis
        Pagamento pgto;
        private short opcao;


        //Inicio do metodo construtor
        public ControlPagamento()
        {
            pgto = new Pagamento();
        }// fim do construtor


        //Get set
        public short ModificarOpcao
        {
            get { return opcao; }
            set { opcao = value; }
        }// Fim do Fet set



        public void  EscolherFormaPagamento()
        {
            Console.WriteLine (pgto.MenuFormaDePagamento()); // Chamando um metodo de Pagamento e mostrando o menu na tela
            ModificarOpcao = Convert.ToInt16(Console.ReadLine());// mostrando a resposta
        }//fim do EscolherFormaPagamento


        public void Operacao()
        {
            EscolherFormaPagamento();

            switch (ModificarOpcao) 
            {
                case 1:
                    Console.WriteLine("Pagamento com Dinherio \n\n");
                    Console.WriteLine("Valor Inserido na máquina: ");
                    double valorInserido = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("\n\nValor do Produto: ");
                    double valorProduto = Convert.ToDouble(Console.ReadLine());

                    //Utilizar o método efetuar pagamento dinheiro
                    pgto.EfetuarPagamentoDinheiro(valorInserido, valorProduto);
                    Console.WriteLine(pgto.imprimir());
                    break;

                case 2:
                    Console.WriteLine("Pagamento com Cartão \n\n");
                    Console.WriteLine("\n\nValor do Produto: ");
                    valorProduto = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("\n\nVCodigo do Cartão: ");
                    int codCartao = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("\n\nBandeira do Cartão: \n1. Visa\n2. Mastercad\n3. Elo");
                    short bandeiraCartao = Convert.ToInt16(Console.ReadLine());


                    //Utilizar o método efetuar pagamento dinheiro
                    pgto.EfetuarPagamentoCartao(valorProduto, codCartao, bandeiraCartao);
                    Console.WriteLine(pgto.imprimir());
                    break;

                default:
                    Console.WriteLine("Impossivel realizar este pagamento tente novamento");
                    break;
            }//fim do switch
        }// fim do Operação




    }//fim da classe
}//fim do metodo
