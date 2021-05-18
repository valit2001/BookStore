using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebUI.Models
{
    public class PagingInfo
    {
        public int TotalItems { get; set; }     // Кл книг
        public int ItemsPerPage { get; set; }   // Кл книг на сторінці
        public int CurrentPage { get; set; }    // Номер поточної сторінки
        public int TotalPages                   // Кл сторінок
        {
            get { return (int)Math.Ceiling((decimal)TotalItems / ItemsPerPage); }
        }
    }
}