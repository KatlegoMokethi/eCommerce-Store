using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace YongzCreative.Models
{
    public class Order
    {
        [BindNever]
        public int OrderID { get; set; }
        [Required(ErrorMessage = "Please enter a name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter the first address line")]
        [DisplayName("Line 1")]
        public string Line1 { get; set; }
        [DisplayName("Line 2")]
        public string Line2 { get; set; }
        [DisplayName("Line 3")]
        public string Line3 { get; set; }
        [Required(ErrorMessage = "Please enter a city name")]
        public string City { get; set; }
        public string Zip { get; set; }
        [BindNever]
        public bool Shipped { get; set; }

        //Navigation property
        [BindNever]
        public ICollection<CartLine> Lines { get; set; }
    }
}
