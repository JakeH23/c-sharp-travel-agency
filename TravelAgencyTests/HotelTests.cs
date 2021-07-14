using c_sharp_travel_agency;
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
        public void CheckIfHotelCostPerNightIsSet()
        {
            var hotel = new Hotel();

            hotel.CostPerNight = 50.6;

            Assert.Equal(50.6, hotel.CostPerNight);
        }

        [Fact]
        public void CheckIfHotelStarRatingIsSet()
        {
            var hotel = new Hotel();

            hotel.StarRating = 5;

            Assert.Equal(5, hotel.StarRating);
        }
    }
}
