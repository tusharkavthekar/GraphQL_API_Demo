using GraphQL_API.Data;
using GraphQL_API.GraphQL.Mutations;
using GraphQL_API.GraphQL.Types;
using GraphQL_API.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//Register Service
builder.Services.AddScoped<IProductService, ProductService>();

//InMemory Database
builder.Services.AddDbContext<DbContextClass>(o => o.UseInMemoryDatabase("GraphQLDemo"));



//builder.Services.AddControllers();
//// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

//GraphQL Config
builder.Services.AddGraphQLServer()
    .AddQueryType<ProductQueryTypes>()
    .AddMutationType<ProductMutations>();

var app = builder.Build();

//Seed Data
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var context = services.GetRequiredService<DbContextClass>();
    SeedData.Initialize(services);
}

//GraphQL
app.MapGraphQL();

//// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}

//app.UseHttpsRedirection();

//app.UseAuthorization();

//app.MapControllers();

app.Run();
