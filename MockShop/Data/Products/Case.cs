namespace MockShop.Data.Products
{
    public class Case : Product
    {
        public FormFactor FormFactor { get; set; }
        public int DriveBays { get; set; }
        public bool RgbSupport { get; set; }
    }
}