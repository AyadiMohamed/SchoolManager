using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Framework;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SchoolApi.Controllers;
using SchoolApi.Models;
using SchoolWebAppClient.Models;

namespace SchoolWebAppClient.Controllers
{
    public class SchoolClientController : Controller
    {
        private readonly SchoolDbContext _context;
        private readonly ILogger<SchoolsController> _logger;
        HttpClient client;
        public SchoolClientController(ILogger<SchoolsController> logger) 
        {
            _logger= logger;
            client = new()
            {
                BaseAddress = new Uri("https://localhost:7198")
            };
        }
        public async Task<ActionResult> GetAllSchools()
        {
            HttpResponseMessage response = await client.GetAsync(client.BaseAddress + "api/Schools/get-all-schools");
            if (response.IsSuccessStatusCode)
            {
                var schools = await response.Content.ReadFromJsonAsync<IEnumerable<SchoolClient>>();
                return View(schools);
            }
            return View();
        }
        public async Task<ActionResult> creatSchool(SchoolClient school)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync("api/Schools/create-school",school);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("GetAllSchools");
            }
            return View();
        }
    }
}
