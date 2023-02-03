using Business.Abstract;
using Business.Concreate;
using DataAccess.Abstract;
using DataAccess.Concreate;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<ITaxonomyService, TaxonomyManager>();
builder.Services.AddScoped<ITaxonomyDal, EfTaxonomyDal>();
builder.Services.AddScoped<IMetarialService, MetarialManager>();
builder.Services.AddScoped<IMetarialDal, EfMetarialDal>();
builder.Services.AddScoped<IProductDal,EfProductDal>();
builder.Services.AddScoped<IProductService,ProductManager>();
builder.Services.AddScoped<IDefinitionDal,EfDefinitionDal>();
builder.Services.AddScoped<IDefinitionService,DefinitionManager>();
builder.Services.AddScoped<IOriginDal , EfOriginDal>();
builder.Services.AddScoped<IOriginService,OriginManager>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
