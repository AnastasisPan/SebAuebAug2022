namespace StudentsAppEmpty
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*var builder = WebApplication.CreateBuilder(args);
             * 
            var app = builder.Build();



            app.Run();*/

            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                }).Build().Run();


            //This Message is shown after Kestrel has stopped
            Console.WriteLine("Thanks for using Students App");
        }
    }
}