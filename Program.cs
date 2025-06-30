var builder = WebApplication.CreateBuilder(args);

// 1st step to add
builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// second step: add MapControllers
app.MapControllers();
// third step: add UseRouting
app.UseRouting();


app.Run();

