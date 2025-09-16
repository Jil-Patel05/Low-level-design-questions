using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LLD_Q.JiraDesign.Enums;

namespace LLD_Q.JiraDesign.Models
{
    public class Task
    {
        public string description;
        public User createdUser;
        public User assignedUser;
        public PRIOTIY priority;
        public ITaskStatus currentStatus;
        public TASK_TYPE type;
        public List<Comment> comments = new List<Comment>();
        public List<Tag> tags = new List<Tag>();
        public object objectToLock = new object();

        public Task(string description, PRIOTIY priority, TASK_TYPE type, User createdUser)
        {
            this.description = description;
            this.priority = priority;
            this.type = type;
            this.createdUser = createdUser;
            this.currentStatus = new Open();
        }

        public void EditDescription(User user, string description)
        {
            if (user == createdUser || user == assignedUser)
            {
                lock (objectToLock)
                {
                    this.description = description;
                    // NOTIFY ASSIGNED USER IF ASSIGNED != CreatedUser           
                }
            }
            else
            {
                Console.WriteLine("Not have right to edit the Description");
            }
        }

        public void AssignUser(User user)
        {
            lock (objectToLock)
            {
                this.assignedUser = user;
                // NOTIFY ASSIGNED USER
            }
        }

        public void ChangePriority(PRIOTIY priority)
        {
            lock (objectToLock)
            {
                this.priority = priority;
                // NOTIFY ASSIGNED USERS about priority
            }
        }

        public void addComments(Comment comment)
        {
            lock (objectToLock)
            {
                comments.Add(comment);
                // NOTIFY USER
            }
        }

        public void addTags(Tag tag)
        {
            lock (objectToLock)
            {
                tags.Add(tag);
                // NOTIFY USER
            }
        }

        public void setCurrentStatus(ITaskStatus status)
        {
            this.currentStatus = status;
        }

        public void changeStatus()
        {
            lock (objectToLock)
            {
                this.currentStatus.nextStatus(this);
            }
        }
    }
}