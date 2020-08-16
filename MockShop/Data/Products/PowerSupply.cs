namespace MockShop.Data.Products
{
    public class PowerSupply : Product
    {
        public int DriveConnectors { get; set; }
        public int Wattage { get; set; }
        public PowerSupplyEfficiency Efficiency { get; set; }
    }
}