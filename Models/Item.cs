
using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GroceryListManager.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }
        
        public string Name { get; set; }
        public float Price { get; set; }
        public DateTime? PurchasedDate { get; set; }
        public int quantity { get; set; }

        public bool IsItemPurchased {
                get {
                    return PurchasedDate != null;
                }
            }
    }
}
            