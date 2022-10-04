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
        public static Produto CadastrarProduto(Produtos p){
            Console.Clear();
            Produto prod = new Produto();
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("|       INFORME OS DADOS DO PRODUTO         |");
            Console.WriteLine("---------------------------------------------");
            Console.Write("Nome: ");
            prod.Nome = Console.ReadLine();
            Console.Write("Codigo: ");
            prod.Codigo = int.Parse(Console.ReadLine());
            int RetornoProcura = p.ProcuraCodigo(prod.Codigo);
            while(RetornoProcura > 0 ){
                Console.WriteLine("ERRO: Codigo ja cadastrado. Digite o codigo novamente.");
                Console.Write("Codigo: ");
                prod.Codigo = int.Parse(Console.ReadLine());
                RetornoProcura = p.ProcuraCodigo(prod.Codigo);
            }
            Console.Write("Custo: R$");
            prod.Custo = double.Parse(Console.ReadLine());
            Console.Write("Venda: R$");
            prod.Venda = double.Parse(Console.ReadLine());
            Console.WriteLine("\nInformações gravadas com sucesso!\n");

            return prod;
        }
        public static void RemoverProduto(Produtos p){
            Console.Clear();
            int i = 0;
            Console.WriteLine("      Nome          |        Codigo       |        Custo        |            Venda       ");            
            foreach (Produto prod in p.ProdutosLista){
                Console.WriteLine(prod.ToString());
                i++;
            }
            if(i >= 1){
            Console.WriteLine("\nDigite o codigo do produto que deseja remover: ");
                int CodigoRemover = int.Parse(Console.ReadLine());
                int RetornoRemover = p.ProcuraCodigo(CodigoRemover);
                if(RetornoRemover > 0 ){
                    p.ProdutosLista.RemoveAt(RetornoRemover - 1);
                    Console.WriteLine("Produto removido com sucesso");
                }else{
                    Console.WriteLine("\nERRO: Codigo não encontrado");
                }
            }else{
                Console.WriteLine("\nNenhum Produto encontrado");
            }
            Console.WriteLine("Aperte ENTER para voltar ao Menu");
            Console.ReadLine();
            
        }
        public static void ListaProdutos(Produtos p){
            Console.Clear();
            Console.WriteLine("      Nome          |         Codigo       |          Custo      |           Venda       ");
            foreach (Produto prod in p.ProdutosLista){
                Console.WriteLine(prod.ToString());
            }
            Console.WriteLine("\n\nAperte ENTER para voltar ao Menu");
            Console.ReadLine();
        }
    }
}