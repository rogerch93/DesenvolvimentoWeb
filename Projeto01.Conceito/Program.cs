var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();

/*
Framework da microsoft
1 - Mais rápido - Foi feito para responder muito rapido as requisições
2 - Multiplataforma - Podemos executar nossos projetos Core em Windows, Linux ou MAcOs
3 - OpenSoucer gratuito para criação de projetos.
*/
