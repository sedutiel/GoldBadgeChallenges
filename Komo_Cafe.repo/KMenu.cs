using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komo_Cafe.repo
{
    public class KMenu
    {
        public string MealLetter { get; set; }
        public string MealName { get; set; }
        public string MealDescription { get; set; }
        public string MealIngredients { get; set; }
        public double MealPrice { get; set; }

        public KMenu() { }

        public KMenu(string mealLetter, string mealName, string mealDescription, string mealIngredients, double mealPrice)
        {
            MealLetter = mealLetter;
            MealName = mealName;
            MealDescription = mealDescription;
            MealIngredients = mealIngredients;
            MealPrice = mealPrice;
        }

    }
}
