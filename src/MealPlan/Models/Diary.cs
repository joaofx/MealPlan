using System;
using System.Collections;
using System.Collections.Generic;

namespace MealPlan.Models
{
    public class Diary
    {
        public string Id { get; set; }
        public DateTime Date { get; set; }
        public List<Meal> Meals { get; set; }
    }
}