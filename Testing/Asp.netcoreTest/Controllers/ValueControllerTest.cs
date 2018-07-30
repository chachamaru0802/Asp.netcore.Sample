using Asp.netcore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Asp.netcoreTest.Controllers
{
   public class ValueControllerTest
    {
        readonly HttpClient _client;

        public ValueControllerTest()
        {
            var builder = new WebHostBuilder()
             .UseEnvironment("Testing")
             .UseStartup<Startup>();

            var server = new TestServer(builder);
            //_context = server.Host.Services.GetService(typeof(ApplicationDbContext)) as ApplicationDbContext;
            _client = server.CreateClient();
        }

        [Fact]
        public async Task Index()
        {
            var res = await _client.GetAsync("/api/Values/");


            res.EnsureSuccessStatusCode();
        }

    }
}
