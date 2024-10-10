using BussinessLogic;
using DataAccess;

var builder = WebApplication.CreateBuilder(args);

// 1
builder.Services.AddDataAccess();

//2
builder.Services.AddBussinessLogic();

//3
builder.Services.AddControllers();

//4
builder.Services.AddSwaggerGen();

var app = builder.Build();

//3
app.MapControllers();

//4
app.UseSwagger();
app.UseSwaggerUI();

app.Run();
