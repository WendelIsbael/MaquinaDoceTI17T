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
        private int bandeiraCartao;
        private double valorMinimo;
        private double valorDoTroco;


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
            ModificarValorMinimo = 50;
            ModificarValorDoTroco = 0;

        }// Fim do metodo construtor

        public Pagamento (int codigo, string descricao, double valorTotal, short formaPagamento, 
                          DateTime horaPagamento, int codCartao, int bandeiraCartao, double valorMinimo, double valorTroco)
        {
            ModificarCodigo = codigo;
            ModificarDescricao = descricao;
            ModificarValorTotal = valorTotal;
            ModificarFormaPagamento = formaPagamento;
            ModificarHoraPagamento = horaPagamento;
            ModificarCodCartao = codCartao;
            ModificarValorMinimo = valorMinimo;
            ModificarValorDoTroco = valorTroco;
        }

        


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

        public int ModificarBandeiraCartao
        {
            get { return this.bandeiraCartao; }
            set { this.bandeiraCartao = value; }
        } // Fim do ModificarBandeiraCartão

        public double ModificarValorMinimo
        {
            get { return this.valorMinimo; }    
            set { this.valorMinimo = value;}
        } // Fim do ModificarValorMinimo


        public double ModificarValorDoTroco
        {
            get { return this.valorDoTroco; }
            set { this.valorDoTroco = value; }
        }

        // Fim do encapsulamento 


        // Metodo Verificar Nota


        //Metodo VerificarTroco
        public string VerificarTroco(double valorMinimo)
        {
            ModificarValorMinimo = valorMinimo;

            {
                string msg = ""; // Criação de uma variavel Local
                Boolean flag = false;
                if (valorMinimo < 50)
                {
                    msg = "Impossivel Realizar pagamento via dinheiro";
                    
                }
                 // Fim do Sé
                return msg;
            } // Fim do Método
        }

        public double EfetuarPagamento( double valorTotal, double valorDeTroco)
        {
            ModificarValorTotal = valorTotal;
            ModificarValorDoTroco = valorDeTroco;
        }



    }// Fim da Classe
} // Fim do projeto
