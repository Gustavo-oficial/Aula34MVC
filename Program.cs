using System;
using Aula34MVC.Controllers;

namespace Aula34MVC
{
    class Program
    {
        static void Main(string[] args)
        {
            ProdutoController produtos = new ProdutoController();
            produtos.Buscar("2");
        }
    }
}
