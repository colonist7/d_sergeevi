using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SEP.Services;

namespace SEP.Controllers
{
    public class CalculatorController : Controller
    {
        private CalculatorService calculatorService = new CalculatorService();
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Operation(string value_a, string value_b, string operation)
        {
            var value_result = CalculatorService.Operation(value_a, value_b, operation);

            return View(value_result);
        }
    }
}