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
        public Produtos()
        {
            ProdutosLista = new List<Produto>();
        }
        
    }
}