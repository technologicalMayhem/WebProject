namespace MockShop.Data.Products
{
    public class Cpu : Product
    {
        public int ComputationPower { get; set; }
        public int Cores { get; set; }
        public CpuSocket Socket { get; set; }
    }
}