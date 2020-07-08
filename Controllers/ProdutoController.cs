using System;
using System.Collections.Generic;
using Aula34MVC.Models;
using Aula34MVC.Views;

namespace Aula34MVC.Controllers
{
    public class ProdutoController
    {
        Produto prodmodel = new Produto();
        
        ProdutoView prodView = new ProdutoView();
        
        public void Listar(){
            List<Produto> lista = prodmodel.Ler();
            prodView.MostrarNoProgram(lista);
        }

        public void Buscar(string _codigo){
            List<Produto> busca = prodmodel.Ler().FindAll(z => z.Codigo == Int16.Parse(_codigo));
            prodView.MostrarNoProgram(busca);
        }

    }
}