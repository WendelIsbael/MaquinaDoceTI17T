using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaDeDoces
{
    class Produto
    {   // Declarando as Variaveis 

        private int codigo;
        private string nome;
        private string descricao;
        private double preco;
        private int quantidade;
        private DateTime dtValidade;
        private Boolean situacao;

        // Metodo Construtor

        // O metodo construtor serve para instanciar as variaveis ou seja dar um valor inicial para elas.
        public Produto()
        {
            ModificarCodigo           = 0;
            ModificarNome            = "";
            ModificarDescricao       = "";
            ModificarPreco           = 0;
            ModificarQuantidade      = 0;
            ModificarDtValidade      = new DateTime(); // valor padrao do datetime  0000/00/00 00:00:00
            ModificarSituacao        = false;

        } // Fim do metodo construtor

        // Metodo construtor com parametro
        public Produto (int codigo,string nome, string descricao,
            double preco, int quantidade, DateTime dtValidade, Boolean situacao)
        {
            ModificarCodigo         = codigo;
            ModificarNome           = nome;
            ModificarDescricao      = descricao;
            ModificarPreco          = preco;
            ModificarQuantidade     = quantidade;
            ModificarDtValidade     = dtValidade;
            ModificarSituacao       = situacao;
        } //Fim do metodo construtor com parametros


        // Metodos Get e Set
        // Metodos de acesso e modificação


        public int ModificarCodigo
        {
            get{
                return this.codigo;
            } //Fim do get - retornar codigo / consultar dado de uma determinada variavel
            
            set{
                this.codigo = value;
            } //Fim do set - modificar codigo
        } //Fim do metodo ModificarCodigo


        public string ModificarNome
        {
            get { return this.nome;}
            set { this.nome = value; }      
        } // Fim do ModificarNome


        public string ModificarDescricao
        {
            get { return this.descricao;}   
            set { this.descricao = value;}
        } // Fim do ModificarDescricao


        public double ModificarPreco 
        {
            get { return this.preco;}
            set { this.preco = value;} 
        } // Fim do ModificarPreco 


        public int ModificarQuantidade
        {
            get { return this.quantidade;}
            set { this.quantidade = value;}
        } //Fim do ModificarQuantidade


        public DateTime ModificarDtValidade
        {
            get { return this.dtValidade;}
            set { this.dtValidade = value;}
        } // FIm do ModificarDtValidade
            

        public Boolean ModificarSituacao
        {
            get { return this.situacao;}
            set { this.situacao = value;}
        } // Fim do ModificarSituacao



        // Metodo Cadastrar Produto
        public void CadastrarProduto(

                int codigo,
                string nome,
                string descricao,
                double preco,
                int quantidadde,
                DateTime dtValidade,
                Boolean situacao
            )
        {
            ModificarCodigo     = codigo;
            ModificarNome       = nome;    
            ModificarDescricao  = descricao;    
            ModificarPreco      = preco;  
            ModificarQuantidade = quantidadde;
            ModificarDtValidade = dtValidade;    
            ModificarSituacao   = situacao;    
        } // Fim do Metodo CadastrarPRoduto


        //Metodo Consultar Produto
        public string ConsultarPrtoduto(int codigo)
        {
            string msg = ""; // Criação de uma variavel Local
            if (ModificarCodigo == codigo)
            {
                msg = "\nCódigo: "              + ModificarCodigo +
                      "\nNome: "                + ModificarNome       +
                      "\nDescrição: "           + ModificarDescricao  +
                      "\nPreço: "               + ModificarPreco      +
                      "\nQuantidade: "          + ModificarQuantidade +
                      "\nData de Validade: "    + ModificarDtValidade +
                      "\nSituação: "            + ModificarSituacao;
            } 
            else
            {
                msg = "O Código digitado não existe";
            }
            return msg;
        } // Fim do metodo ConsultarProduto


        // Metodo atualizar

        public Boolean AtualizarProduto(int codigo, int campo, string novoDado)
        {
             Boolean flag = false;

                if (ModificarCodigo == codigo)
                {
                    switch (campo)
                    {
                        case 1:
                            ModificarNome = novoDado;
                            flag = true;
                            break;

                        case 2:
                            ModificarDescricao = novoDado;
                            flag = true;
                            break;

                        case 3:
                            ModificarPreco = Convert.ToDouble(novoDado);
                            flag = true;
                            break;

                        case 4:
                            ModificarQuantidade = Convert.ToInt32(novoDado);
                            flag = true;
                            break;

                        case 5:
                            ModificarDtValidade = Convert.ToDateTime(novoDado);
                            flag = true;
                            break;

                        case 6: 
                            ModificarSituacao = Convert.ToBoolean(novoDado);
                            flag = true;
                            break;

                        default:
                            break;

                    } // Fim do Escolha
                    return flag;
                } // Fim do if/Se
                return flag;
        }// Fim do atualizarProduto


        // Metodo Desativar Produto
        public Boolean AlterarSituacao(int codigo)
        {
            Boolean flag = false;

            if (ModificarCodigo == codigo)
            {
                if (ModificarSituacao == true)
                {
                    ModificarSituacao = false;
                }
                else
                {
                    ModificarSituacao = true;
                }// fim do se
            }// fim do se
           return false;
        } // Fim AlterarSituacao
            
        
        public Boolean SolicitarProduto(int codigo)
        {
            Boolean flag = false;

                if(ModificarCodigo == codigo)
                {
                if (ModificarQuantidade <= 3)
                {
                    return true;
                }
                }
            return flag;
            
        }

    } // Fim da Classe
} // Fim do Projeto
