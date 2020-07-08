using System;
using System.Collections.Generic;
using Aula34MVC.Models;

namespace Aula34MVC.Views
{
    public class ProdutoView
    {
        public void MostrarNoProgram(List<Produto> lista){
            foreach(Produto item in lista){
                Console.WriteLine($"{item.Nome} - {item.Preco}");
            }
        }
    }
}