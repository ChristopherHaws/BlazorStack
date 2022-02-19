using System.Diagnostics;
using BlazorStyled;

namespace Sample.Server;

public class Startup {
	private readonly IWebHostEnvironment env;

	public Startup(IWebHostEnvironment env) {
		this.env = env;
	}

	public void ConfigureServices(IServiceCollection services) {
		services.AddRazorPages();
		services.AddServerSideBlazor();
		services.AddBlazorStyled(this.env.IsDevelopment(), Debugger.IsAttached);
	}

	public void Configure(IApplicationBuilder app, IWebHostEnvironment env) {
		if (env.IsDevelopment()) {
			app.UseDeveloperExceptionPage();
		} else {
			app.UseExceptionHandler("/Error");
			// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
			app.UseHsts();
		}

		app.UseHttpsRedirection();
		app.UseStaticFiles();

		app.UseRouting();

		app.UseEndpoints(endpoints => {
			endpoints.MapBlazorHub();
			endpoints.MapFallbackToPage("/_Host");
		});
	}
}
