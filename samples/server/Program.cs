using Sample.Server;

Host.CreateDefaultBuilder(args)
	.ConfigureWebHostDefaults(webBuilder => {
		webBuilder.UseStartup<Startup>();
	})
	.Build()
	.Run();
