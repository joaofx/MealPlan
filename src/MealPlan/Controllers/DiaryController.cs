using System;
using System.Collections.Generic;
using System.Web.Mvc;
using MealPlan.Models;

namespace MealPlan.Controllers
{
    public class DiaryController : Controller
    {
        public ActionResult Index()
        {
            return View(new Diary
            {
                Date = DateTime.Today,
                Meals = new List<Meal>()
                {
                    new Meal() { Id = "pre-workout", Name = "Pre-workout" },
                    new Meal() { Id = "pos-workout", Name = "Pos-workout" }
                }
            });
        }
    }
}