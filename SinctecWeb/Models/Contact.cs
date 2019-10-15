using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SinctecWeb.Models
{
    public class Contact
    {
        [Key]
        public int IdContact { get; set; }

        public string NameContact { get; set; }

        public string AddressContact { get; set; }

        public int NumberContact { get; set; }

        public string NeighborhoodContact { get; set; }

        public string TelephoneContact { get; set; }

        public string CellphoneContact { get; set; }

        public string EmailContact { get; set; }

        public string HomePageContact { get; set; }

        public string ObservationContact { get; set; }
    }
}