using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectB_Core;

namespace ProjectB_Core_Test
{
    [TestClass]
    public class ChocolateVendingMachineTest
    {
        private IVendingMachine vendingMachine;
        
        [TestInitialize]
        public void TestIintialize()
        {
            this.vendingMachine = new ChocolateVendingMachine();
        }
        
        
        [TestMethod]
        public void TestForGettingItemFromVendingMachine()
        {
            // Arrange

            // Act
            var actualResult = this.vendingMachine.BuyItem();

            // Assert
            Assert.IsFalse(string.IsNullOrEmpty(actualResult));
        }
    }
}
