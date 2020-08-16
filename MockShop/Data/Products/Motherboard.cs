namespace MockShop.Data.Products
{
    public class Motherboard : Product
    {
        public FormFactor FormFactor { get; set; }
        public CpuSocket Socket { get; set; }
        public int MemorySlots { get; set; }
        public int MemorySlotGeneration { get; set; }
        public int SataPorts { get; set; }
        public int PciSlots { get; set; }
    }
}