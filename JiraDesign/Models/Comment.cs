using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LLD_Q.JiraDesign.Models
{
    public class Comment
    {
        public string description;
        public User user;
        public DateTime creationTime;
        public DateTime editTime;
        public Comment(string description, User user)
        {
            this.description = description;
            this.user = user;
            this.creationTime = DateTime.Now;
            this.editTime = DateTime.Now;
        }

        public void EditComment(string description)
        {
            this.description = description;
            this.editTime = DateTime.Now;
        }
    }
}