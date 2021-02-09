using System.ComponentModel.DataAnnotations;

namespace Models.DataModels
{
    public class Product
    {
        [Key]
        public long PkProductId { get; set; }

        [MaxLength(500)]
        public string ProductName { get; set; }
        [MaxLength(500)]
        public string ProductDescription { get; set; }
        public long FkProductCategoryId { get; set; }
        public double ProductPrice { get; set; }
        public int RowStatus { get; set; }
    }
}
