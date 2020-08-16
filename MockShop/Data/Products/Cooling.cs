using System.Collections.Generic;

namespace MockShop.Data.Products
{
    public class Cooling : Product
    {
        public bool IsLiquid { get; set; }
        public virtual ICollection<CpuSocket> CompatibleSockets { get; set; }
    }
}