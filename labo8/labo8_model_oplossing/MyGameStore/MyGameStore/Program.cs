
using AP.MyGameStore.BLL.Extensions;
using AP.MyGameStore.DAL;
using AP.MyGameStore.DAL.Extensions;
using Microsoft.EntityFrameworkCore;
using MyGameStore.Controllers;

namespace MyGameStore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllers();

            builder.Services.RegisterBLL();
            builder.Services.RegisterDAL();

            //builder.Services.AddDbContext<MyGameStoreContext>(options => options.UseSqlServer("name=ConnectionStrings:MyGameStore"));
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

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}