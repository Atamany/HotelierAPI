using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelierAPI_EntityLayer.Concrete
{
    public class Guest
    {
        public int GuestID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }
        public string TCKN { get; set; }
        public string? Telefon { get; set; }
        public string? Mail { get; set; }
    }
}
