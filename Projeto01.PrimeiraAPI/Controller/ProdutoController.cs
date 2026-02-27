using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projeto04.PrimeiraAPI.Model;

namespace Projeto04.PrimeiraAPI.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private static List<Produto> produtos = new List<Produto>();

        //Método POST: api/produto
        [HttpPost]

        public IActionResult Post([FromBody] Produto novoProduto)
        {
            if (novoProduto == null) 
            {
                return BadRequest();
            }

            novoProduto.Id = produtos.Count + 1;

            produtos.Add(novoProduto);


            return Ok(novoProduto);

        }

        [HttpGet]
        public IActionResult BuscarTodos()
        {
            return Ok(produtos);
        }

        [HttpGet("{id}")]
        public IActionResult BuscarPorID(int id)
        {
            Produto? produto = produtos.FirstOrDefault(x => x.Id == id);

            if(produto == null)
            {
                return NotFound("Produto não Encontrado");
            }

            return Ok(produto);
        }

        //PUT - Atualizar um produto ja existente.
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Produto produto)
        {
            Produto? produtoExistente = produtos.FirstOrDefault(produto => produto.Id == id);

            if(produtoExistente == null)
            {
                return NotFound("Produto não Existente");
            }

            //Atualizando Produto existente.

            produtoExistente.Nome = produto.Nome;
            produtoExistente.Preco = produto.Preco;

            return Ok(produtoExistente);
        }

        //DELETE - Deletar produo
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Produto? produtoExistente = produtos.FirstOrDefault(produto => produto.Id == id);

            if (produtoExistente == null)
            {
                return NotFound("Produto não Existente");
            }

            //Remover Produto existente.
            produtos.Remove(produtoExistente);

            return NoContent();
        }


    }
}
