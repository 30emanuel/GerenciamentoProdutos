using System;
using GerenciamentoProdutos.entities;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace GerenciamentoProdutos
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Console.Write("Nome:");
            string nome = Console.ReadLine();
            Console.Write("Codigo: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write("Custo: ");
            double custo = double.Parse(Console.ReadLine());
            Console.Write("Venda: ");
            double venda = double.Parse(Console.ReadLine());

            Produto.Add(new Produtos{
                Nome = nome,
                Codigo = codigo,
                Custo = custo,
                Venda = venda
            });

            foreach (var Produtos in Produto)
            {
                Console.WriteLine(Produtos.Nome);
                Console.WriteLine(Produtos.Codigo);
                Console.WriteLine(Produtos.Custo);
                Console.WriteLine(Produtos.Venda);
            }
            Console.ReadLine();*/
            Produtos produto = new Produtos();
            int itemMenu = 0;
            while (itemMenu != 4){
                switch (itemMenu)
                {
                    case 0:
                        Tela.Menu();
                        itemMenu = int.Parse(System.Console.ReadLine()); 
                        break;
                    case 1:
                        Produto prod = Tela.CadastrarProduto();
                        produto.AdicionarProduto(prod);
                        itemMenu = 0;
                        break;
                    case 3:
                        itemMenu = 0;
                        break;
                }
            }
        }
    }
}
