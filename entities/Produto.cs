using System;
using GerenciamentoProdutos.entities;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
namespace GerenciamentoProdutos.entities
{
    public class Produto
    {
        public string Nome { get; set; }
        public int Codigo { get; set; }
        public double Custo { get; set; }
        public double Venda { get; set; }
    }
}