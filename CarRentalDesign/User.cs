using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LLD_Q.CarRentalDesign
{
    public class User
    {
        public string userName;
        public IList<Registration> registrations = new List<Registration>();
        public User(string userName)
        {
            this.userName = userName;
        }
        public void addRegistration(Registration registration)
        {
            this.registrations.Add(registration);
        }

        public void CancelRegistration(Guid guid)
        {
            Registration? r = this.registrations.Where((reg) => reg.bookingId == guid).FirstOrDefault();
            if (r != null)
            {
                r.registrationStatus = REGISTRATION_STATUS.CANCELED;
            }
            // Perform refund here based on day where it is booked
            double refund = r.bookingAmount;
        }
    }
}