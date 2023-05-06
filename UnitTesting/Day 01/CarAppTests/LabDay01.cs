using CarsApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CarAppTests
{
    [TestClass]
    public class LabDay01
    {
        #region Aseert

        [TestMethod]
        public void TimeToCoverProvidedDistance_ShouldCalculateCorrectly_WhenVelocityIsPositive()
        {
            // Arrange
            double distance = 100.0;
            double velocity = 10.0;

            var car = new Car();
            car.Velocity = velocity;

            // Act
            double time = car.TimeToCoverProvidedDistance(distance);

            // Assert
            double expectedTime = distance / velocity;
            Assert.AreEqual(expectedTime, time, "The calculated time was incorrect.");
        }

        [TestMethod]
        public void TimeToCoverProvidedDistance_ShouldReturnZero_WhenVelocityIsZero()
        {
            // Arrange
            double distance = 100.0;
            var car = new Car();
            car.Velocity = 0.0;

            // Act
            double time = car.TimeToCoverProvidedDistance(distance);

            // Assert
            Assert.AreEqual(0.0, time, "The calculated time was incorrect.");
        }

        [TestMethod]
        [ExpectedException(typeof(NotImplementedException))]
        public void Accelerate_ThrowsNotImplementedException_ForUnknownCarType()
        {
            // Arrange
            var car = new Car(); // Create a new car with an unknown car type
            car.Type = (CarType)100;

            // Act
            car.Accelerate();
        }

        [TestMethod]
        public void Stop_IsTrue()
        {
            // Arrange
            var car = new Car();
            car.Velocity = 50.0;

            // Act
            car.Stop();

            // Assert
            Assert.IsTrue(car.Velocity == 0, "The car did not stop.");
        }

        [TestMethod]
        public void Stop_IsFalse()
        {
            // Arrange
            var car = new Car();
            car.Velocity = 0.0;

            // Act
            car.Stop();

            // Assert
            Assert.IsFalse(car.Velocity == 10, "The car stopped, but the velocity was not zero.");
        }


        #endregion

        #region String Assert
        //  01 
        [TestMethod]
        public void GetDirection_DoesNotMatch_Forward()
        {
            // Arrange
            var car = new Car();
            car.DrivingMode = DrivingMode.Reverse;
            //var driving = new Driving(DrivingMode.Forward); // Create a new driving instance in Forward mode

            // Act
            var direction = car.GetDirection();

            // Assert
            StringAssert.DoesNotMatch(direction, new Regex("^Forward$"), "Direction should not be Forward.");
        }

        //  02
        [TestMethod]
        public void GetDirection_Matches_Reverse()
        {
            // Arrange
            var car = new Car();
            car.DrivingMode = DrivingMode.Reverse;
            //var driving = new Driving(DrivingMode.Reverse); // Create a new driving instance in Reverse mode

            // Act
            var direction = car.GetDirection();

            // Assert
            StringAssert.Matches(direction, new Regex("^Reverse$"), "Direction should be Reverse.");
        }

        //   03
        [TestMethod]
        public void GetDirection_StartsWith_S()
        {
            // Arrange
            var car = new Car();
            // var driving = new Driving(DrivingMode.Stopped); // Create a new driving instance in Stopped mode
            car.DrivingMode = DrivingMode.Stopped;
            // Act
            var direction = car.GetDirection();

            // Assert
            StringAssert.StartsWith(direction, "S", "Direction should start with the letter S.");
        }
        #endregion

        #region Assert Collection
        [TestMethod]
        public void GetMyCar_IsNotNull()
        {
            // Arrange
            var car = new Car();

            // Act
            var myCar = car.GetMyCar();

            // Assert
            Assert.IsNotNull(myCar, "The returned car object was null.");
        }


        [TestMethod]
        public void GetAllStoreCars_AddCar_AllItemsAreUnique()
        {
            // Arrange
            var car1 = new Car();
            var car2 = new Car();
            var car3 = new Car();
            var carStore = new CarStore(new List<Car> { car1, car2, car3 });

            // Act
            var cars = carStore.GetAllStoreCars();

            // Assert
            CollectionAssert.AllItemsAreUnique(cars);
        }


        [TestMethod]
        public void GetAllStoreCars_ReturnsAllCarsOfCarType()
        {
            // Arrange
            var car1 = new Car();
            var car2 = new Car();
            var car3 = new Car();
            var carStore = new CarStore(new List<Car> { car1, car2, car3 });

            // Act
            var cars = carStore.GetAllStoreCars();

            // Assert
            CollectionAssert.AllItemsAreInstancesOfType(cars, typeof(Car));
        }
        #endregion
    }
}
