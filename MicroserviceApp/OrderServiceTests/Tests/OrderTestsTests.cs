using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderService.Controllers;

namespace OrderService.Tests.Tests
{
    [TestClass()]
    public class OrderTestsTests
    {
        [TestMethod]
        public void GivenOrderSix_WhenOrderActionIsCalled_ThenResultIsEmpty()
        {
            // Arrange & Act
            var expectedResult = "";
            var ctr = new OrderController();
            var actulResult = ctr.Get("Order 6");

            // Assert
            Assert.AreEqual(expectedResult, actulResult);
        }

        [TestMethod]
        public void GivenOrderOne_WhenOrderActionIsCalled_ThenResultAsExpected()
        {
            // Arrange & Act
            var expectedResult = "Order 1";
            var ctr = new OrderController();
            var actulResult = ctr.Get("Order 1");

            // Assert
            Assert.AreEqual(expectedResult, actulResult);
        }
    }
}