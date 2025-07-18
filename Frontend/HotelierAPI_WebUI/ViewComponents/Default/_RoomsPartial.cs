﻿using HotelierAPI_WebUI.DTOs.RoomDTO;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HotelierAPI_WebUI.ViewComponents.Default
{
    public class _RoomsPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _RoomsPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7135/api/Room");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultRoomDTO>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
