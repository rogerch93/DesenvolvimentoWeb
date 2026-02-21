using Projeto01.WebForms.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Projeto01.WebForms
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //Vincular a lista de produtos ao gridview
                gridProduto.DataSource = ObterProdutos();
                gridProduto.DataBind();
            }
        }

        protected void tbnEnvio_Click(object sender, EventArgs e)
        {
            string nomeUsuario = txtNome.Text;

            lblNomeEnviado.Text = $"Olá {nomeUsuario}! Bem vindo ao ASP.NET Web Forms!";

            string OpcaoSelecionada = dropOpcoes.SelectedValue;

            lblOpcaoSelecionada.Text = $"Você selecionou: {OpcaoSelecionada}";
        }

        private List<Produto> ObterProdutos()
        {
            return new List<Produto>
            {
                new Produto{ Id = 1, Nome = "Teclado", Preco = 100.00},
                new Produto{ Id = 2, Nome = "Mouse", Preco = 50.00},
                new Produto{ Id = 3, Nome = "Monitor", Preco = 500.00}

            };
        }
    }
}