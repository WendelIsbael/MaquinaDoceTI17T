using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaDeDoces
{
    class ControlProduto
    {

        Produto prod;
        private int opcao;



        // Metodo Construtor serve para instanciar as variaveis ou seja dar um valor inicial
        public ControlProduto() 
        {
            prod = new Produto();
            opcao = -1;
        } // Fim do metodo construtor


        // Metodod Get set
        public int ModificarOpcao
        {
            get { return opcao; }
            set { opcao = value; }
        }// fim 



        // Menu
        public void Menu()
        {
            Console.WriteLine("Escolha uma das opções abaixo: \n"   +
                              "0. Sair\n"                           +
                              "1. Cadastrar Produto\n"              +
                              "2. Consultar Produto\n"              +
                              "3. Atualizar Produto\n"              +
                              "4. Mudar Situação");
            ModificarOpcao = Convert.ToInt32(Console.ReadLine());
            Console.Clear();// Limpa tela
        }// fim do menu




        // Realizar a operação
        public void Operacao()
        {
            do
            {
                Menu();// Mostrando o menu na tela
                switch (ModificarOpcao)
                {
                    case 0:
                        Console.WriteLine("Obrigado");
                        break;

                    case 1:
                        ColetarDados();
                        break;

                    case 2:
                        Consultar();
                        break;

                    case 3:
                        Consultar();
                        break;

                    case 4:
                        AlterarSituacao();
                        break;

                    default
                        :
                        Console.WriteLine("Opção escolhida não e valido");
                        break;
                }// Fim do Switch
            } while (ModificarOpcao != 0);
            Console.Clear();// Limpa tela
        }// Fim do metodo operação




        // Criando um metodo de solicitação de dados
        public void ColetarDados()
        {
            // Coletando dados
            Console.WriteLine("Informe o codigo: ");
            int codigo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o nome do produto: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Infome a descrição do protudo: ");
            string descricao = Console.ReadLine();

            Console.WriteLine("Infome o preço do produto: ");
            double preco = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Infome a quantidade do produto: ");
            int quantidade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe a data de validade do lote: ");
            DateTime dtValidade = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Infome a situação: True - Ativo | False - Inativo");
            Boolean situacao = Convert.ToBoolean(Console.ReadLine());



            // Cadastrar um Produto
            prod.CadastrarProduto(codigo, nome, descricao, preco, quantidade, dtValidade, situacao); // Criando uma coneção com a classe construtora "Produto"
            Console.WriteLine("PRODUTO CADASTRADO!");
            Console.Clear();// Limpa tela


        }// fim do ColetarDados



        //Consultar dados
        public void Consultar()
        {
            Console.WriteLine("\n\n\nInforme o codigo do produto que deseja consultar: ");
            int codigo = Convert.ToInt32(Console.ReadLine());
            //Escrevendo resultado da consulta
            Console.WriteLine("Os dados do produto são: \n\n\n" + prod.ConsultarPrtoduto(codigo));

            // Chamando o metodo Consultar
            prod.ConsultarPrtoduto(codigo);
        }// Fim do metodo



        // Atualizar
        public void Atualizar()
        {
            Console.WriteLine("\n\nInforme o código do produto que deseja atualizar: ");
            int codigo = Convert.ToInt32(Console.ReadLine());


            short campo = 0;

            do
            {
                Console.WriteLine("Informe o campo que deseja atualizar de acordo com a regra abaixo: \n" +
                                  "1. Nome\n" +
                                  "2. Descrição\n" +
                                  "3. Preço\n" +
                                  "4. quantidade\n" +
                                  "5. Data de validade" +
                                  "6. Situação");
                campo = Convert.ToInt16(Console.ReadLine());

                //Avisando o usuario
                if ((campo < 1) || (campo > 6))
                {
                    Console.WriteLine("Erro, esxolha um codigo entere 1 e 6");
                }
            } while ((campo < 1) || campo > 6);

                  



            Console.WriteLine(" Informe o dado para a atualização: ");
            string novoDado = Console.ReadLine();

            // Chamando o metodo de atualização
            prod.AtualizarProduto(codigo, campo, novoDado);
            Console.WriteLine("Atualizado !");
        }// Fim do metodo atulizar



        // Mudar a situção
        public void AlterarSituacao()
        {
            Console.WriteLine("Informe o codigo do produto que deseja alterar o status: ");
            int codigo = Convert.ToInt32(Console.ReadLine());

            // chamar o metodo alterarSituacao
            prod.AlterarSituacao(codigo);
            Console.WriteLine("Atualizado !");
        }// Fim do AlterarSituacao

    }// Fim da Classe
}// Fim do Projeto
