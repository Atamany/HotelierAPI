﻿using System.ComponentModel.DataAnnotations;

namespace HotelierAPI_WebUI.DTOs.ServiceDTO
{
    public class CreateServiceDTO
    {
        [Required(ErrorMessage = "Hizmet ikon linki giriniz...")]
        public string ServiceIcon { get; set; }
        [Required(ErrorMessage = "Hizmet başlığı giriniz...")]
        [StringLength(100, ErrorMessage = "Hizmet başlığı en fazla 100 karakter olabilir.")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Hizmet açıklaması giriniz...")]
        [StringLength(500, ErrorMessage = "Hizmet açıklaması en fazla 500 karakter olabilir.")]
        public string Description { get; set; }
    }
}
