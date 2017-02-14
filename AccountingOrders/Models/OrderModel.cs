using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AccountingOrders.Models
{
    [Table("Order")]
    public class OrderModel
    {
        [Key]
        public int Id { set; get; }
        public int Number { set; get; }
        public DateTime Date { set; get; }
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string MidleName { set; get; }
        [NotMapped]
        public double TotalAmount { set; get; }
    }
}