using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BusinessLogic;

namespace ACM.BusinessLogicTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            //Arrange
            /* In this section, we can set any preparation that we need
             * We can create an instance of the class.
             * 
             */

            Customer customer = new Customer();
            customer.FirstName = "Jason";
            customer.LastName = "Bond";

            string expected = "Bond, Jason";


            //Act - actual value that has
            string actual = customer.FullName;

            //Assert - whether this two matches or not.
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameTestValidLastName()
        {
            //Arrange
            /* In this section, we can set any preparation that we need
             * We can create an instance of the class.
             * 
             */

            Customer customer = new Customer();
            customer.FirstName = "Jason";
            //customer.LastName = "Bond";

            string expected = "Jason";


            //Act - actual value that has
            string actual = customer.FullName;

            //Assert - whether this two matches or not.
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameTestValidFirstName()
        {
            //Arrange
            /* In this section, we can set any preparation that we need
             * We can create an instance of the class.
             * 
             */

            Customer customer = new Customer();
            //customer.FirstName = "Jason";
            customer.LastName = "Bond";

            string expected = "Bond";


            //Act - actual value that has
            string actual = customer.FullName;

            //Assert - whether this two matches or not.
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void staticTest()
        {
            //Arrange
            var c1 = new Customer();
            c1.FirstName = "Jason";
            Customer.instanceCount += 1;

            var c2 = new Customer();
            c2.LastName = "Bond";
            Customer.instanceCount += 1;

            var c3 = new Customer();
            c3.FirstName = "Tom";
            Customer.instanceCount += 1;

            //Act

            //Assert
            Assert.AreEqual(3, Customer.instanceCount);


            
        }

        //create a automated test for valid values
        [TestMethod]
        public void validateValid()
        {
            //--Arrange
            var Customer = new Customer();
            Customer.LastName = "Shanon";
            Customer.EmailAddress = "shanon@gmail.com";

            var expected = true;

            //--Actual
            var actual = Customer.validate();


            //Assert
            Assert.AreEqual(expected, actual);

        }

        //Create a test method for invalid value
        [TestMethod]
        public void validateMissingLastName()
        {
            //--Arrange
            var Customer = new Customer();
            //Customer.LastName = "Shanon";
            Customer.EmailAddress = "shanon@gmail.com";

            var expected = false;

            //--Actual
            var actual = Customer.validate();


            //Assert
            Assert.AreEqual(expected, actual);

        }

        //Create a test method for invalid value
        [TestMethod]
        public void validateMissingEmail()
        {
            //--Arrange
            var Customer = new Customer();
            Customer.LastName = "Shanon";
            //Customer.EmailAddress = "shanon@gmail.com";

            var expected = false;

            //--Actual
            var actual = Customer.validate();


            //Assert
            Assert.AreEqual(expected, actual);

        }

    }
}
