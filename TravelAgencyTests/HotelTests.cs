using c_sharp_travel_agency.models;
using Xunit;

namespace TravelAgencyTests
{
    public class HotelTests
    {
        [Fact]
        public void CheckIfHotelNameIsSet()
        {
            var hotel = new Hotel();

            hotel.Name = "Ibis";

            Assert.Equal("Ibis", hotel.Name);
        }

        [Fact]
        public void CheckIfHotelCityIsSet()
        {
            var hotel = new Hotel();

            hotel.City = "Manchester";

            Assert.Equal("Manchester", hotel.City);
        }

        [Fact]
        public void CheckIfHotelCostPerNightIsSetWithInteger()
        {
            var hotel = new Hotel();

            hotel.CostPerNight = 50;

            Assert.Equal(50, hotel.CostPerNight);
        }

        [Fact]
        public void CheckIfHotelCostPerNightIsSetWithDecimal()
        {
            var hotel = new Hotel();

            hotel.CostPerNight = 50.6;

            Assert.Equal(50.6, hotel.CostPerNight);
        }

        [Fact]
        public void CheckIfHotelStarRatingIsSetWithInteger()
        {
            var hotel = new Hotel();

            hotel.StarRating = 5;

            Assert.Equal(5, hotel.StarRating);
        }

        [Fact]
        public void CheckIfHotelStarRatingIsSetWithDecimal()
        {
            var hotel = new Hotel();

            hotel.StarRating = 4.5;

            Assert.Equal(4.5, hotel.StarRating);
        }
    }
}
