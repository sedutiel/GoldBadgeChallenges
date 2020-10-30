using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komo_Cafe.repo
{
    public class Menu_Repo
    {
        //List that Points to Your Object By Name
        private List<KMenu> _menu = new List<KMenu>();
        //C--Create
        //R--Read
        //U--Update
        //D--Delete
        //CREATE
        public bool AddMenu(KMenu newMenu)
        {
            int startingCount = _menu.Count;
            _menu.Add(newMenu);

            bool wasAdded = (_menu.Count > startingCount) ? true : false;
            return wasAdded;
        }


        //A method for printing entire menu

        public List<KMenu> GetFullMenu()
        {
            return _menu;
        }

        //a method to delete items from the menu by letter
        public bool DeleteExistingItem(KMenu existingItem)
        {
            bool deleteResult = _menu.Remove(existingItem);
            return deleteResult;
        }

        //a method to get the meal by letter so I can call this method in my delete method
        public KMenu GetMealByLetter(string mealLetter)
        {
            foreach (KMenu content in _menu)
            {
                if (content.MealLetter.ToLower() == mealLetter.ToLower())
                {
                    return content;
                }
            }
            return null;
        }
    }

}
