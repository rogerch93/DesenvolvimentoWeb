
//Cria um construtor do aplicativo web
var builder = WebApplication.CreateBuilder(args);

// Add os serviços MVC - permitino o uso dos controladores
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Verifica se o ambiente não é de desenvolvimento.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
//Permitir o uso de arquivo esatico (CSS, arquivos, imagens)
app.UseStaticFiles();

//Permite o sistema de roteamento
app.UseRouting();

//Habilita a autorização, verifica se o usuario tem permissão para acessar determinado recursos.
app.UseAuthorization();

// Mapea a rota padrão para os controladores
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Produto}/{action=Index}/{id?}");

// iniciar a aplicação e aguarda por solicitações.
app.Run();
