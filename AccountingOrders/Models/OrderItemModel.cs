using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AccountingOrders.Models
{
    [Table("OrderItem")]
    public class OrderItemModel
    {
        [Key]
        public int Id { set; get; }
        public string Name { set; get; }
        public int Count { set; get; }
        public double Price { set; get; }
        [ForeignKey("OrderModelId")]
        protected virtual OrderModel OrderModel { get; set; }
        [NotMapped]
        public double Cost { set; get; }
        public int OrderModelId { set; get; }
    }
}