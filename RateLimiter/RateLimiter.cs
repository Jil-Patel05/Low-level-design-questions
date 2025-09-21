using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LLD_Q.RateLimiter.Models;

namespace LLD_Q.RateLimiter
{
    public class RateLimiter
    {
        private LeakyBucket lb = new LeakyBucket();
        public RateLimiter()
        {
        }

        public void UserRequests(string userId)
        {
            this.lb.applyRateLimiting(userId);
        }
    }
}