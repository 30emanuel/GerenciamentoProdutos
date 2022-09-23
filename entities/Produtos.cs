using System;
using GerenciamentoProdutos.entities;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
namespace GerenciamentoProdutos.entities
{
    public class Produtos
    {
        public List<Produto> ProdutosLista { get; set; }
        public void AdicionarProduto(Produto p)
        {
            ProdutosLista.Add(p);
        }
        public void RemProduto(int remover){
            ProdutosLista.RemoveAt(remover);
        }
        public Produtos()
        {
            ProdutosLista = new List<Produto>();
        }
        public string RetornaNomeArquivo(){
            string NomeArquivo = "dados";
            string Diretorio = Directory.GetCurrentDirectory();

            string ArquivoComCaminho = Diretorio + @"\" + NomeArquivo + ".xml"; 
            return ArquivoComCaminho; 
        }
        public string GravarProduto(){
            string NomeArquivo = RetornaNomeArquivo();
            
            if (File.Exists(NomeArquivo) == true)
            {
                File.Delete(NomeArquivo);
            }

            StreamWriter sw = new StreamWriter(NomeArquivo);
            sw.WriteLine("<XML>");
            sw.WriteLine("  <Produtos>");
            
            int contaproduto = 1;
            
            foreach (Produto prod in ProdutosLista)
            {   
                sw.WriteLine("      <Prod" + contaproduto +">");
                sw.WriteLine("          <Nome>" + prod.Nome + "</Nome>");
                sw.WriteLine("          <Codigo>" + prod.Codigo  + "</Codigo>");
                sw.WriteLine("          <Custo>" + prod.Custo.ToString("F2", CultureInfo.InvariantCulture)  + "</Custo>");
                sw.WriteLine("          <Venda>" + prod.Venda.ToString("F2",CultureInfo.InvariantCulture)  + "</Venda>");
                sw.WriteLine("      </Prod" + contaproduto +">");
                contaproduto ++;
            }
            sw.WriteLine("  </Produtos>");
            sw.WriteLine("</XML>");
            sw.Close();

            return "";
        }
    }
}