using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProductService.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductService.Controllers.Tests
{
    [TestClass()]
    public class ProductControllerTests
    {
        [TestMethod]
        public void GivenProductSix_WhenOrderActionIsCalled_ThenResultIsEmpty()
        {
            // Arrange & Act
            var expectedResult = "";
            var ctr = new ProductController();
            var actulResult = ctr.Get("Product 6");

            // Assert
            Assert.AreEqual(expectedResult, actulResult);
        }

        [TestMethod]
        public void GivenProductOne_WhenOrderActionIsCalled_ThenResultAsExpected()
        {
            // Arrange & Act
            var expectedResult = "Product 1";
            var ctr = new ProductController();
            var actulResult = ctr.Get("Product 1");

            // Assert
            Assert.AreEqual(expectedResult, actulResult);
        }
    }
}