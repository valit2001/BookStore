using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ShippingDetails
    {
        [Required(ErrorMessage = "Укажіть Ваше ім'я")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Адреса доставки")]
        [Display(Name="Вулиця та будинок")]
        public string Line1 { get; set; }
        //[Display(Name = "ДРУГА адреса")]
        //public string Line2 { get; set; }
        //[Display(Name = "Третя адреса")]
        //public string Line3 { get; set; }

        [Required(ErrorMessage = "Укажіть місто")]
        [Display(Name = "Місто")]
        public string City { get; set; }

        [Required(ErrorMessage = "Укажіть країну")]
        [Display(Name = "Країна")]
        public string Country { get; set; }

        public bool GiftWrap { get; set; }
    }
}
