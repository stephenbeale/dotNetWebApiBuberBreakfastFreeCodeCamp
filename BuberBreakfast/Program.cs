//Builder variable can be uses for dependency injection
var builder = WebApplication.CreateBuilder(args);
//Create scope and organise it this way
{
    builder.Services.AddControllers();
}
var app = builder.Build();
{
    app.UseHttpsRedirection();
    app.MapControllers();
    app.Run();
}