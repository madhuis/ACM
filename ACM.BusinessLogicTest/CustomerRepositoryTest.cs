using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BusinessLogic;

namespace ACM.BusinessLogicTest
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void RetrieveExisting()
        {
            //-- Arrange
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "fbaggins@hobbiton.me",
                FirstName = "Frodo",
                LastName = "Baggins"
            };
        }
    }
}
