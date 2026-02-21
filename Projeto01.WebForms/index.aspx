<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Projeto01.WebForms.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>WEB</title>

    <style>
        body{
            margin:20px
        }
        label,input,select, button{
            margin: 10px;
            display:block;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblNome" runat="server" Text="Digite seu nome"></asp:Label>
            <br />
            <asp:TextBox ID="txtNome" runat="server" ></asp:TextBox>
            <br />
           <asp:DropDownList ID="dropOpcoes" runat="server">
                <asp:ListItem Value="Opcao1">Opção 1</asp:ListItem>
                <asp:ListItem Value="Opcao2">Opção 2</asp:ListItem>
                <asp:ListItem Value="Opcao3">Opção 3</asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:Button ID="tbnEnvio" runat="server" Text="Enviar" Onclick="tbnEnvio_Click"/>
            <br />


            <asp:Label ID="lblNomeEnviado" runat="server" Text=""></asp:Label>
            <br />
            <asp:Label ID="lblOpcaoSelecionada" runat="server" Text=""></asp:Label>
            <br />
            
            <asp:GridView ID="gridProduto" runat="server" AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField DataField="id" HeaderText="id" />
                    <asp:BoundField DataField="nome" HeaderText="Nome do Produto" />
                    <asp:BoundField DataField="Preco" HeaderText="Preço" />
                </Columns>
            </asp:GridView>
        
        
        </div>
    </form>
</body>
</html>
