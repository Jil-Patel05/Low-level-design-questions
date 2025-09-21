using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LLD_Q.RateLimiter.Interfaces;

namespace LLD_Q.RateLimiter.Models
{
    public class LeakyBucket : IRateLimiterAlgo
    {
        private Timer? timer;
        private List<string> users;
        private const int CAPACITY = 10;
        private readonly object _lock = new object();
        public LeakyBucket()
        {
            users = new List<string>();
            timer = new Timer(removeUsers, null, 0, 25);
        }
        public void applyRateLimiting(string userId)
        {
            lock (_lock)
            {
                if (users.Count < CAPACITY)
                {
                    users.Add(userId);
                    Console.WriteLine("user is passed to service");
                }
                else
                {
                    Console.WriteLine($"User with userId:{userId} is discarded due to very heavy load on site");
                }
            }
        }

        private void stopTimer()
        {
            timer?.Dispose();
            timer = null;
        }

        private void removeUsers(object? state)
        {
            lock (_lock)
            {
                if (users.Count >= 1)
                {
                    users.RemoveAt(users.Count - 1);
                }
                else
                {
                    this.stopTimer();
                }
            }
        }

    }
}