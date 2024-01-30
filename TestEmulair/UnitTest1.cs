using Emulair.BusinessLogic.Implementation.News.Models;
using Emulair.Controllers;
using EmulairWEB.Models;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using NuGet.Protocol;
using Xunit.Abstractions;
using static System.Net.Http.Json.JsonContent;

namespace TestEmulair
{
    public class EmployeeControllerTests: IClassFixture<WebApplicationFactory<Program>>
    {
        private readonly HttpClient _client;



        public EmployeeControllerTests(WebApplicationFactory<Program> factory)
        {
            _client = factory.CreateClient();
            
        }

        [Fact]
        public async Task Faq_test_controller()
        {

            var response = await _client.GetAsync("FAQ/Hello");
            response.EnsureSuccessStatusCode();
            response.Content.ReadAsStringAsync().Result.Should().Be("Alex");
        }

        [Fact]
        void SimpleTest()
        {

            (1 + 1).Should().Be(2);
        }
    }
}