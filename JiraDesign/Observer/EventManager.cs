using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LLD_Q.JiraDesign.Enums;

namespace LLD_Q.JiraDesign.Observer
{
    public class EventManager
    {
        public Notify notify;
        public EventManager(Notify notify)
        {
            this.notify = notify;
        }

        public void HandleNotification(Notify notify)
        {
            switch (notify.action)
            {
                case ACTIONS.TASK_CREATED:
                    Console.WriteLine($"{notify.user.userName} crated this ticket");
                    break;
                default:
                    break;
            }
        }
    }
}