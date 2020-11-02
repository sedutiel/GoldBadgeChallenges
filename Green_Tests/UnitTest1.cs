using System;
using KomodoGreen;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vehicle_Repo;

namespace Green_Tests
{
    [TestClass]
    public class ProgramUITests
    {

        private Vehicle __vehicle = new Vehicle();
        private VehicleRepo _vehiclerepo = new VehicleRepo();

        [TestMethod]
        public void GetFullMenu_OutputShouldContainFullMenu()
        {

            _vehiclerepo.AddVehicleToList(_vehicle);

            List<Vehicle> menu = _vehiclerepo.GetFullList();

            Assert.IsTrue(menu.Contains(_vehicle));

        }


        [TestMethod]
        public void GetVehicleByType_ShouldReturnCorrectContent()
        {
            //Arrange

            _vehiclerepo.AddVehicleToList(_vehicles);
            string type = "A";

            //Act
            Vehicle searchResult = _vehiclerepo.GetVehicleByType(type);
            //Assert
            Assert.AreEqual(searchResult.Type, type);
        }

        [TestMethod]
        public void DeleteExistingItem_ShouldReturnFalse()
        {

            _vehiclerepo.DeleteVehicle(_content);

            List<Vehicle> menu = _vehiclerepo.GetFullList();

            Assert.IsFalse(menu.Contains(_content));

        }


        [TestMethod]
        public void AddVehicleToList_ShouldGetCorrectBoolean()
        {

            //Act
            bool addResult = _vehiclerepo.AddVehicleToList(_content);

            //Assert
            Assert.IsTrue(addResult);
        }

    }
}
    

