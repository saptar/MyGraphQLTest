using MyGraphQLDemo.Queries;
using MyGraphQLDemo.repositories;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddGraphQLServer()
    .AddQueryType<CustomerQuery>();
builder.Services.AddSingleton<CustomerRepository>();
var app = builder.Build();

app.UseRouting();
app.MapGraphQL();

app.MapGet("/", () => "Hello World!");

app.Run();
