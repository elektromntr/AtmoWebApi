﻿using DataAccess.Configuration;
using DataAccess.Migrations;
using DataAccess.Repository;
using Logic.Services;
using Logic.Services.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace AtmoWebApi
{
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddDbContext<AtmoContext>(options => options.UseSqlServer(
				Configuration["Data:AtmoWebApi:ConnectionString"]));
			services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
			services.AddTransient<ITicketService, TicketService>();
			services.AddControllers();
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}
			else
			{
				// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
				app.UseHsts();
			}
			app.UseRouting();
			app.UseEndpoints(endpoints => endpoints.MapControllers());
			app.UseHttpsRedirection();
		}
	}
}
