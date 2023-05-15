using System.ComponentModel.DataAnnotations;

namespace Proiect.DTO
{
    public class Address
    {
        public int AddressId { get; set; }

        [Display(Name = "Street")]
        public string Street { get; set; }

        [Display(Name = "City")]
        public string City { get; set; }

    }
}
