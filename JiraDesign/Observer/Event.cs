using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LLD_Q.CarRentalDesign;
using LLD_Q.JiraDesign.Enums;

namespace LLD_Q.JiraDesign.Observer
{
    public class Event
    {
        public ACTIONS action;
        public User user;
    }
}