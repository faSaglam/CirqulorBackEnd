using Business.Abstract;
using Business.Concreate;
using DataAccess.Abstract;
using DataAccess.Concreate;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<ITaxonomyService, TaxonomyManager>();
builder.Services.AddScoped<ITaxonomyDal, EfTaxonomyDal>();
builder.Services.AddScoped<IMaterialService, MaterialManager>();
builder.Services.AddScoped<IMetarialDal, EfMetarialDal>();

builder.Services.AddScoped<IDefinitionDal,EfDefinitionDal>();
builder.Services.AddScoped<IDefinitionService,DefinitionManager>();
builder.Services.AddScoped<IOriginDal , EfOriginDal>();
builder.Services.AddScoped<IOriginService,OriginManager>();
builder.Services.AddScoped<IFormDal, EfFormDal>();
builder.Services.AddScoped<IFormService, FormManager>();
builder.Services.AddScoped<IPlantDal, EfPlantDal>();
builder.Services.AddScoped<IPlantService, PlantManager>();
builder.Services.AddScoped<IMaterialMetricDal, EfMaterialMetricDal>();
builder.Services.AddScoped<IMaterialMetricService, MaterialMetricManager>();
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
