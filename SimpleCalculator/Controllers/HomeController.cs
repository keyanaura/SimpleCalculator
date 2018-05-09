using Calculator;
using SimpleCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleCalculator.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
         /// <summary>
         /// This is to test Github Desktop App.
         /// </summary>
         /// <param name="calculationModel"></param>
         /// <returns></returns>
        [HttpPost]
        public ActionResult Add(CalculationModel calculationModel)
        {
            if (ModelState.IsValid)
            {
                calculationModel.Result = new Calculator.Calculator().Add(calculationModel.Value1, calculationModel.Value2);
                return View("Index", calculationModel);
            }

            return View("Index");
        }
    }
}