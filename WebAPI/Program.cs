using Core.Application.Interfaces;
using Core.Application.Services;

var builder = WebApplication.CreateBuilder(args);

// Tambahkan layanan ke container
builder.Services.AddControllers();

// Tambahkan Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<IUserService, UserService>();

var app = builder.Build();

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

// Gunakan Swagger
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
    c.RoutePrefix = string.Empty; // Membuat Swagger tersedia di root URL
});

app.UseHttpsRedirection();
app.UseAuthorization();

app.MapControllers();

app.Run();
