using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LLD_Q.JiraDesign.Models
{
    public class User
    {
        public string id;
        public string name;
        public User(string id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}