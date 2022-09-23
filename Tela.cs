using System;
using GerenciamentoProdutos.entities;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
namespace GerenciamentoProdutos
{
    class Tela
    {
        
        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine("|===============================|");
            Console.WriteLine("|            MENU               |");
            Console.WriteLine("|===============================|");
            Console.WriteLine("|1 - Cadastrar Produto          |");
            Console.WriteLine("|2 - Remover Produto            |");
            Console.WriteLine("|3 - Listar Produtos            |");
            Console.WriteLine("|4 - Sair                       |");
            Console.WriteLine("|===============================|");
        }
        public static Produto CadastrarProduto(){
            Console.Clear();
            Produto prod = new Produto();
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("|       INFORME OS DADOS DO PRODUTO         |");
            Console.WriteLine("---------------------------------------------");
            Console.Write("Nome: ");
            prod.Nome = Console.ReadLine();
            Console.Write("Codigo: ");
            prod.Codigo = int.Parse(Console.ReadLine());
            Console.Write("Custo: ");
            prod.Custo = double.Parse(Console.ReadLine());
            Console.Write("Venda: ");
            prod.Venda = double.Parse(Console.ReadLine());
            Console.WriteLine("\nInformações gravadas com sucesso!\n");

            return prod;
        }
        public static void RemoverProduto(Produtos p){
            Console.Clear();
            int i = 1;
            Console.WriteLine("Nome        |Codigo     |Custo      |Venda      ");
            foreach (Produto prod in p.ProdutosLista){
                Console.WriteLine(prod.ToString() + "   Numero: " + i);
                i++;
            }
            Console.Write("\nDigite o numero do produto que deseja remover: ");
            int removerProduto = int.Parse(Console.ReadLine());
            removerProduto = removerProduto - 1 ;
            p.RemProduto(removerProduto);
        }
        public static void ListaProdutos(Produtos p){
            Console.Clear();
            Console.WriteLine("Nome        |Codigo     |Custo      |Venda      ");
            foreach (Produto prod in p.ProdutosLista){
                Console.WriteLine(prod.ToString());
            }
            Console.WriteLine("\n\nAperte ENTER para voltar ao Menu");
            Console.ReadLine();
        }
    }
}