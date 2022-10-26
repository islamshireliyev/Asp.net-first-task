using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using System;
using System.Net;
using System.Net.Mail;


namespace bigOn.WebUI
{
    public class Program
    {
        public static void Main(string[] args)
        {

            SendMailcustom();

           CreateHostBuilder(args).Build().Run();
        }

        

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });


        private static void SendMailcustom()
        {
            string login = "shireliyev2020@mail.ru";
            string password = "VsFbRUUTDkk6v0GM39rg";
        }
    }


    
}