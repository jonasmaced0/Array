using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio05
{
    public class Dados
    {
        public static List<Produto> GetProdutos()
        {
            List<Produto> produtos = new()
            {
                new Produto() { Nome = "Clips", Preco = 3.95m },
                new Produto() { Nome = "Caneta", Preco = 5.99m },
                new Produto() { Nome = "Lápis", Preco = 4.15m },
                new Produto() { Nome = "Estojo", Preco = 6.99m },
                new Produto() { Nome = "Caderno", Preco = 7.55m }
            };
            return produtos;
 
        }
    }

}

