using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Projeto02.Razor.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }

        [BindProperty]
        public string Nome { get; set; }
        [BindProperty]
        public int Idade { get; set; }
        [BindProperty]
        public bool Lembrar { get; set; }

        public IActionResult OnPost()
        {
            if(Idade <= 0)
            {
                ModelState.AddModelError(string.Empty, "Preencha a idade corretamente");

                return Page();
            }

            //retornar a pagiana com dados capturaados
            return Page();
        }
    }
}
