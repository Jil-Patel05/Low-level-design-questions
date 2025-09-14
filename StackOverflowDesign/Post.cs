using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LLD_Q.StackOverflowDesign
{
    public class Post
    {
        public Guid guid;
        public string body;
        public User user;

        public Post(string body, User user)
        {
            this.body = body;
            this.user = user;
            this.guid = Guid.NewGuid();
        }

    }
}