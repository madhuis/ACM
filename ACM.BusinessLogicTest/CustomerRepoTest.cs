using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BusinessLogic;

namespace ACM.BusinessLogicTest
{
    [TestClass]
    public class CustomerRepoTest
    {
        [TestMethod]
        public void TestMRetrieveExisting()
        {
            //-- Arrange
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "me@gmail.com",
                FirstName = "Jacky",
                LastName = "Smith"
            };

            //-- Act
            var actual = customerRepository.Retrieve(1);

            //-- Assert
            //Assert.AreEqual(expected, actual);

            Assert.AreEqual(expected.CustomerID, actual.CustomerID);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
        }
    }
}
