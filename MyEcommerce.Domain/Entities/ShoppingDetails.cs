using System.ComponentModel.DataAnnotations;

namespace MyEcommerce.Domain.Entities
{
    public class ShippingDetails
    {
        [Required(ErrorMessage = "Please Enter your name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please Enter the first address line")]
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string Line3 { get; set; }

        [Required(ErrorMessage = "Enter City Details")]
        public string City { get; set; }
        [Required(ErrorMessage = "Enter State Details")]
        public string State { get; set; }
        [Required(ErrorMessage = "Enter  PostCode")]
        public string Zip { get; set; }
        public string Country { get; set; }
        public bool GiftWrap { get; set; }
    }
}
