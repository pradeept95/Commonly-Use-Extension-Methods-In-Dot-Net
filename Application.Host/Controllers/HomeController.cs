using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Application.Host.Models;
using Application.Helpers.Extensions;

namespace Application.Host.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var result = new List<StringStatus<string>>();
            var objTrimInner = new StringStatus<string>() {
                ActionName = "Trim All Inner Spaces",
                ExtensionMethod = "TrimInnerSpaces",
                OriginalString = "This is     string with  multiple   spaces in this paragraph. It      should remove all     unnecessary spaces  from the string.       ", 
            };

            objTrimInner.NormalizedResult = objTrimInner.OriginalString.TrimInnerSpaces();

            result.Add(objTrimInner);


            return View(result);
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

    public class StringStatus<T> where T: class
    {
        public string ActionName { get; set; }
        public string ExtensionMethod { get; set; }
        public string OriginalString { get; set; }
        public T NormalizedResult { get; set; }
        public object ExtraResult { get; set; }
    }
}
