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
        public List<Task> tasks = new List<Task>();
        public User(string id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public void addTask(Task task)
        {
            this.tasks.Add(task);
        }

        public void removeTask(Task task)
        {
            this.tasks.Remove(task);
            // Notify assignee about deleted Task if it is present
        }
    }
}