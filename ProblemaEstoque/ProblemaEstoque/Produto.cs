using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemaEstoque
{
    internal class Produto
    {
        public string name;
        public double preco;
        public int qty;

        public double TotalValue()
        {
            return preco * qty;
        }

        public void AddProduct(int quantity)
        {
            qty += quantity;           
        }

        public void DeleteProduct(int quantity)
        {
            qty -= quantity;
        }
        public string GetUpdate(string name, double price, int qty)
        {
            return "Nome: " + name + "\nPreco: " + price + "\nQuantidade em estoque: " + qty +
                 "\nValor total : " + qty * price;
        }
       
    }
}
