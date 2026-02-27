using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Projeto05.EntityFrameWork.Model;


//ORM
//OBJECT RELATIONAL MAPPER

//code-first - o banco de dados não precisa ser criado antes 

//Gerencia a conexão e manipulação das entidades de dados
public class ApplicationDbContext: DbContext
{
    public DbSet<Produto> Produtos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=")
    }
}