using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LLD_Q.RateLimiter.Interfaces
{
    public interface IRateLimiterAlgo
    {
        public void applyRateLimiting(string userId);
    }
}