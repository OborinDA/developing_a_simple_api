﻿using System.Linq;
using ToursWebApi.Entities;

public class ResponseHotel
{
    public ResponseHotel(Hotel hotel)
    {
        Id = hotel.Id;
        Name = hotel.Name;
        CountOfStars = hotel.CountOfStars;
        CountryName = hotel.Country.Name;
        HotelImage = hotel.HotelImage.FirstOrDefault()?.ImageSource;
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public int CountOfStars { get; set; }
    public string CountryName { get; set; }
    public byte[] HotelImage { get; set; }
}