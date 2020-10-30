using System;
using System.Collections.Generic;
using Komo_Cafe.repo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KomodoCafeTest
{



    [TestClass]
    public class ProgramUITests
    {

        private KMenu _content = new KMenu();
        private Menu_Repo _repo = new Menu_Repo();

        [TestMethod]
        public void GetFullMenu_OutputShouldContainFullMenu()
        {

            _repo.AddMenu(_content);

            List<KMenu> menu = _repo.GetFullMenu();

            Assert.IsTrue(menu.Contains(_content));

        }


        [TestMethod]
        public void GetMealByLetter_ShouldReturnCorrectContent()
        {
            //Arrange

            _repo.AddMenu(_content);
            string mealLetter = "A";

            //Act
            KMenu searchResult = _repo.GetMealByLetter(mealLetter);
            //Assert
            Assert.AreEqual(searchResult.MealLetter, mealLetter);
        }

        [TestMethod]
        public void DeleteExistingItem_ShouldReturnFalse()
        {

            _repo.DeleteExistingItem(_content);

            List<KMenu> menu = _repo.GetFullMenu();

            Assert.IsFalse(menu.Contains(_content));

        }


       [TestMethod]
       public void AddMenu_ShouldGetCorrectBoolean()
        {
           
            //Act
            bool addResult = _repo.AddMenu(_content);

            //Assert
            Assert.IsTrue(addResult);
        }

    }
}



