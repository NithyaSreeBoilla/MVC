using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using mvcdemo.Models;
using mvcdemo.Views.services;

namespace mvcdemo.Controllers
{
    public class HomeController : Controller
    {
     
        public IActionResult Add(int a,int b)
        {
            int result = a + b;
            return View(result);
        }
        public  IActionResult  SayHello(string fn,string ln)
        {
            Person p1 = new Person(){FirstName = "farid", LastName = "sourav"};
            Person p2 = new Person() { FirstName = "sridhar", LastName = "shiva" };
            Person p3 = new Person() { FirstName = "sai", LastName = "eswar" };
            List<Person> list = new List<Person>() { p1, p2, p3 };
            return View(list);
        }
        private readonly ILogger<HomeController> _logger;
        private  readonly IMyDependency _dependency;
        public  HomeController(ILogger<HomeController> logger,IMyDependency dependency)
        {
            _logger = logger;
            //dependency = new MyDependency();
            _dependency = dependency;
            dependency.WriteMessage("testing");
        }

        public IActionResult Index(string id)
        {
            ViewBag.Id = id;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
