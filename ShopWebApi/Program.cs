using Microsoft.EntityFrameworkCore;
using Shop.Persistence.EF;
using Shop.Persistence.EF.Customers;
using Shop.Persistence.EF.OrderDetails;
using Shop.Persistence.EF.Orders;
using Shop.Persistence.EF.Products;
using Shop.Services.Contracts;
using Shop.Services.Customers;
using Shop.Services.Customers.Contracts;
using Shop.Services.OrderDetails;
using Shop.Services.OrderDetails.Contracts;
using Shop.Services.Orders;
using Shop.Services.Orders.Contracts;
using Shop.Services.Products;
using Shop.Services.Products.Contracts;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services
    .AddDbContext<EFDataContext>(
        option => option.UseSqlServer(
            builder.Configuration
                .GetConnectionString(
                    "DefaultConnection")));
builder.Services.AddScoped<UnitOfWorks, EFUnitOfWork>();

builder.Services.AddScoped<CustomerService, CustomerAppService>();
builder.Services.AddScoped<CustomerRepository, EFCustomerRepository>();

builder.Services.AddScoped<OrderDetailService, OrderDetailAppService>();
builder.Services.AddScoped<OrderDetailRepository, EFOrderDetailRepository>();

builder.Services.AddScoped<OrderService, OrderAppService>();
builder.Services.AddScoped<OrderRepository, EFOrderRepository>();

builder.Services.AddScoped<ProductService, ProductAppService>();
builder.Services.AddScoped<ProductRepository, EFProductRepository>();




var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
