using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaDeDoces
{
    class Program
    {
        static void Main(string[] args)
        {
            // Conectando com a classe Produto
            ControlProduto controlProd = new ControlProduto();

            //Chmando o metodo Principal operação
            controlProd.Operacao();

            // Mantem a janeqla aberta, mas e o mesmo que o leia esperando que o usuario digite algo
            Console.ReadLine(); 

        }// Fim do metodo main
    }// Fim da Classe
}// Fim do projeto
