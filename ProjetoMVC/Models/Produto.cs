namespace Projeto03.ProjetoMVC.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }



        // Metodo que retorna uma lista de produto

        public static List<Produto> ListaDeProdutos = new List<Produto>()
        {
            new Produto {Id = 1, Nome = "Notebook", Preco = 3500.00},
            new Produto {Id = 2, Nome = "Smartphone", Preco = 2500.00 },
            new Produto {Id = 3, Nome = "Tablet", Preco = 2000.00}
        };
    }
}
