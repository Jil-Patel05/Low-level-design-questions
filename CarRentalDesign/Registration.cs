using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LLD_Q.CarRentalDesign
{
    public enum REGISTRATION_STATUS
    {
        BOOKED,
        IN_PROGRESS,
        CANCELED
    }
    public class Registration
    {
        public Guid bookingId;
        public Vehicle vehicle;
        public User user;
        public DateOnly startDate;
        public DateOnly endDate;
        public double bookingAmount;
        public REGISTRATION_STATUS registrationStatus;

        public Registration(Vehicle vehicle, User user, DateOnly startDate, DateOnly endDate, double bookingAmount)
        {
            this.bookingId = Guid.NewGuid();
            this.user = user;
            this.startDate = startDate;
            this.endDate = endDate;
            this.registrationStatus = REGISTRATION_STATUS.BOOKED;
            this.bookingAmount = bookingAmount;
        }

        public void cancelTheRegistration()
        {
            this.registrationStatus = REGISTRATION_STATUS.CANCELED;
        }
    }
}