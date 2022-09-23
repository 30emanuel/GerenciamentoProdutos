using System;
using System.Globalization;
namespace GerenciamentoProdutos.entities
{
    public class Produto
    {
        public string Nome { get; set; }
        public int Codigo { get; set; }
        public double Custo { get; set; }
        public double Venda { get; set; }
        public override string ToString()
        {
            return Nome 
            + "     |" + Codigo 
            + "     |" + Custo.ToString("F2", CultureInfo.InvariantCulture) 
            + "     |" + Venda.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}