using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LLD_Q.CarRentalDesign
{
    public class Location
    {
        public string Country { get; private set; }
        public string State { get; private set; }
        public string City { get; private set; }
        public int Pincode { get; private set; }
        public string Address { get; private set; }

        public Location(string country, string state, string city, int pincode, string address)
        {
            this.Pincode = pincode;
            this.State = state;
            this.Country = country;
            this.City = city;
            this.Address = address;
        }
    }
}