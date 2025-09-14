using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LLD_Q.StackOverflowDesign.enums;

namespace LLD_Q.StackOverflowDesign.Observer
{
    public class Event
    {
        public EVENT_TYPE eventType;
        public User user;
        public VOTE vote;

        public Event(EVENT_TYPE eventType, User user, VOTE vote)
        {
            this.eventType = eventType;
            this.user = user;
            this.vote = vote;
        }
    }
}