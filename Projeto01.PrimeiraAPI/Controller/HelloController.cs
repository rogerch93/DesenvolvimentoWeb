using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Projeto04.PrimeiraAPI.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get() 
        {
            return Ok("Olá. Mundo");    
        }

        //Siginificado de REST

        //Representional State Transfer. Arquitetura.

        //GET - Recupera dados
        //POST - Enviar dados ou criar novos recursos.
        //PUT - Atualiza os Recursos Existentes
        //DELETE - Exclui os dados 
    }
}
