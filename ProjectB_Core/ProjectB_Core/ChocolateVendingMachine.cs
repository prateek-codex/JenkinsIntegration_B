
namespace ProjectB_Core
{
    public class ChocolateVendingMachine : IVendingMachine
    {
        private double cost = 100;
        public string BuyItem()
        {
            return "Item bought at: Rs. " + this.cost;
        }
    }
}
