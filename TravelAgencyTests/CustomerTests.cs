using System;
using c_sharp_travel_agency;
using Xunit;

namespace TravelAgencyTests
{
    public class CustomerTests
    {
        [Fact]
        public void CheckIdIsSetForCustomer()
        {
            var customer = new Customer();

            customer.Id = Guid.NewGuid();

            Assert.NotEqual(Guid.Empty, customer.Id);
        }

        [Fact]
        public void CheckFirstNameIsSetForCustomer()
        {
            var customer = new Customer();
            customer.FirstName = "jake";

            Assert.Equal("jake", customer.FirstName);
        }

        [Fact]
        public void CheckSurnameIsSetForCustomer()
        {
            var customer = new Customer();
            customer.Surname = "Heaney";

            Assert.Equal("Heaney", customer.Surname);
        }

        [Fact]
        public void CheckIsAcceptingMarketingIsSetAsDefaultForCustomer()
        {
            var customer = new Customer();

            Assert.False(customer.IsAcceptingMarketing);
        }

        [Fact]
        public void CheckIsAcceptingMarketingIsSetAsTrueForCustomer()
        {
            var customer = new Customer();
            customer.IsAcceptingMarketing = true;

            Assert.True(customer.IsAcceptingMarketing);
        }
    }
}
