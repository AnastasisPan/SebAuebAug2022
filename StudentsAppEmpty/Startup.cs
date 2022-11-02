namespace StudentsAppEmpty
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");

            }
            if (env.IsDevelopment())
            {
                // Enable HTTP strict Transport Security
                // to force all trafic over HTTPS and to
                // prevent user from using untrusted or
                // invalid certificates
                app.UseHsts();
            }

            app.UseRouting();
            // Redirect HTTP requests to HTTPS
            app.UseHttpsRedirection();

            app.UseDefaultFiles();
            app.UseStaticFiles();

            //app.MapGet("/", () => "Hello World!");
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                endpoints.MapGet("/hello", () => "Hello World!");
            });
        }
    }
}
