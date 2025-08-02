namespace HotelierAPI_WebUI.DTOs.GuestDTO
{
    public class ResultGuestDTO
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
