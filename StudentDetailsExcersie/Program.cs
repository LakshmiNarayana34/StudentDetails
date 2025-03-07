
using Microsoft.EntityFrameworkCore;
using StudentDetailsExcersie.Model;
using StudentDetailsExcersie.Data;
using StudentDetailsExcersie.Mapping;
using StudentDetailsExcersie.Repositories;
namespace StudentDetailsExcersie
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddDbContext<StudentContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("StudentConnectionString")));

            builder.Services.AddAutoMapper(typeof(AutoMappingProfiles));

            builder.Services.AddScoped<IStudentRepository,SQLStudentRepository>();

            var app = builder.Build();

            //  Configure the HTTP request pipeline.

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
