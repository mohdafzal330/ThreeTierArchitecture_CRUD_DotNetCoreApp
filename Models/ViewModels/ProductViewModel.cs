namespace Models.ViewModels
{
    public class ProductViewModel
    {
        public long PkProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public string CategoryName { get; set; }
        public double ProductPrice { get; set; }
    }
}