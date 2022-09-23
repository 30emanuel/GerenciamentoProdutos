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
                        Console.Write("Deseja cadastrar outro produto? S-Sim e N-Não: ");
                        string NovoProduto = Console.ReadLine();
                        if (NovoProduto == "s")
                        {
                            itemMenu = 1;
                        }
                        else
                        {
                            itemMenu = 0;
                        }
                        break;
                    case 2:
                        Tela.RemoverProduto(produto);
                        itemMenu = 0;
                        break;
                    case 3:
                        Tela.ListaProdutos(produto);
                        itemMenu = 0;
                        break;
                }
            }
            string retorno = produto.GravarProduto();

            if (retorno != "") 
            {
                Console.WriteLine(retorno);
                Console.WriteLine("O sistema será encerrado!, você perderá suas informações");
                Console.ReadLine();
            }
        }
    }
}
