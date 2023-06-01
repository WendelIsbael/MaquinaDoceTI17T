using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaDeDoces
{
    class Pagamento
    {
        // Decalarando as Variaveis
        private int codigo;
        private string descricao;
        private double valorTotal;
        private short formaPagamento;
        private DateTime horaPagamento;
        private int codCartao;
        private short bandeiraCartao;
        private double trocoInicial;
        private double ;


        // Metodo Construtor
        public Pagamento ()
        {
            ModificarCodigo = 0;
            ModificarDescricao = "";
            ModificarValorTotal = 0;
            ModificarFormaPagamento = 0;
            ModificarHoraPagamento = new DateTime();
            ModificarCodCartao = 0;
            ModificarBandeiraCartao = 0;
            ModificarTrocoInicial = 100;
            ModificarValorDoTroco = 0;

        }// Fim do metodo construtor


        // Encapsulando as variaveis atraves do get set

        public int ModificarCodigo
        {
            get { return this.codigo; }
            set { this.codigo = value; }
        } // Fim do ModificarCodigo

        public string ModificarDescricao
        {
            get { return this.descricao; }
            set { this.descricao = value;}
        } // FIm do ModificarDescricao

        public double ModificarValorTotal
        {
            get { return this.valorTotal; }
            set { this.valorTotal = value;}
        } // Fim do ModificarValorTotal

        public short ModificarFormaPagamento
        {
            get { return this.formaPagamento;}
            set { this.formaPagamento= value;}
        } // Fim do ModificarFormaPagamento

        public DateTime ModificarHoraPagamento
        {
            get { return this.horaPagamento; }
            set { this.horaPagamento = value; }
        } // Fim do ModificarHoraPagamento

        public int ModificarCodCartao
        {
            get { return this.codCartao; }
            set { this.codCartao = value;}
        } // Fim do ModificarCodCartão

        public short ModificarBandeiraCartao
        {
            get { return this.bandeiraCartao; }
            set { this.bandeiraCartao = value; }
        } // Fim do ModificarBandeiraCartão

        public double ModificarTrocoInicial
        {
            get { return this.trocoInicial; }    
            set { this.trocoInicial = value;}
        } // Fim do ModificarTrocoInicial


        public double ModificarValorDoTroco
        {
            get { return this.valorDoTroco; }
            set { this.valorDoTroco = value; }
        }

        // Fim do encapsulamento 


        // Metodo VerificarNotas
        public string VerificarNotas(double entradaDinheiro, double valorProduto)
        {
            if(entradaDinheiro > valorProduto)
            {
                return "OK";
            }
            else
            {
                return "NOK";
            }
        }
        // fim do VerificarNotas


        public Boolean ExisteTroco(double entradaDinherio, double valorProduto)
        {
            string resposta = VerificarNotas(entradaDinherio, valorProduto);

            if (entradaDinherio > valorProduto)
            {
                return true;
            }
            return false;
        }
        //Fim do VerificarTroco


        public string VerificarTroco (double entradaDinheiro, double valorProduto)
        {
           
            Boolean respTroco = false;
            respTroco = ExisteTroco(entradaDinheiro, valorProduto);
           
                
                if ((respTroco == true) && ((entradaDinheiro - valorProduto) < ModificarTrocoInicial))
                {
                    return "Troco: " + (entradaDinheiro - valorProduto);
                }
                else if (( entradaDinheiro - valorProduto) >= ModificarTrocoInicial)
                {
                    return "Impossivel realizar a operação com dinheiro, por favor tente outra forma de pagamento";
                }
                return "Não a Troco";
                // Fim do if

        }// fim do verificarTroco
        
        
        public string MenuEscolherFormaPagamento()
        {
            return "Escolha uma das opções abaixo: " + "\n1. Dinheiro \n2. Cartão";
        }// Fim do metodo

        public void ColetarFormaPagamento(short opcao)
        {
            ModificarFormaPagamento = (opcao);

        }


        // Inicio do EfetuarPagamento
        public string EfetuarPagamento( double entradaPagamento, double valorProqduto)
        {
            string resp = "";

            switch (opcao)
            {
                case 1:
                resp = VerificarNotas(entradaPagamento, valorProqduto);
                if (resp == "OK")
                {
                    VerificarTroco(entradaPagamento, valorProqduto);
                        ModificarCodigo = ModificarCodigo + 1;
                        ModificarValorTotal = valorProqduto;
                        ModificarFormaPagamento = opcao;

                }   
                else
                {

                }
            } 
            
            



            
        }



    }// Fim da Classe
} // Fim do projeto
