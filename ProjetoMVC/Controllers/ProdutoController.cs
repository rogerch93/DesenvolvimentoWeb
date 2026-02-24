using Microsoft.AspNetCore.Mvc;
using Projeto03.ProjetoMVC.Models;

namespace Projeto03.ProjetoMVC.Controllers
{
    /*
        Pseudocódigo / plano detalhado:
        1. Obter a lista de produtos a partir do modelo (`Produto.ListaDeProdutos`).
        2. Evitar atribuição inútil: garantir que a variável seja usada.
        3. Passar a lista para a view chamando `View(produtos)` para que a variável não seja considerada inútil.
        4. Manter a estrutura atual do controller e apenas corrigir o retorno da action `Index`.
        */

    //ProdutoController é responsavel por lidar com as requisições relacionadas a produtos 
    public class ProdutoController : Controller
    {
        public IActionResult Index()
        {
            //Obter a lista de produtos no Model
            List<Produto> produtos = Produto.ListaDeProdutos; 
            //Enviando a lista de produtos para view
            return View(produtos);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Produto produto)
        {
            produto.Id = Produto.ListaDeProdutos.Max(x => x.Id)+ 1;
            Produto.ListaDeProdutos.Add(produto);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            // Encontrar o produto pelo id e enviar para a view para preencher o formulário
            Produto produtoExistente = Produto.ListaDeProdutos.FirstOrDefault(p => p.Id == id);
            if (produtoExistente == null)    
            {
                return NotFound();
            }

            return View(produtoExistente);
        }

        [HttpPost]
        public IActionResult Edit(Produto produto)
        {
            Produto produtoExistente = Produto.ListaDeProdutos.FirstOrDefault(p => p.Id == produto.Id);

            if (produtoExistente != null)
            {
                produtoExistente.Nome = produto.Nome;
                produtoExistente.Preco = produto.Preco;
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Excluir(int id)
        {
            // Encontrar o produto pelo id e enviar para a view para preencher o formulário
            Produto produtoExistente = Produto.ListaDeProdutos.FirstOrDefault(p => p.Id == id);
            if (produtoExistente == null)
            {
                return NotFound();
            }

            return View(produtoExistente);
        }

        [HttpPost]
        public IActionResult ExcluirConfirmado(int id)
        {
            Produto produtoExistente = Produto.ListaDeProdutos.FirstOrDefault(p => p.Id == id);
            if (produtoExistente == null)
            {
                return NotFound();
            }
            Produto.ListaDeProdutos.Remove(produtoExistente);

            return View("Index");
        }
    }
}
