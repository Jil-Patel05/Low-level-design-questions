using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LLD_Q.JiraDesign.Enums;

namespace LLD_Q.JiraDesign.Models
{
    public interface ITaskStatus
    {
        public void nextStatus(Task task);
    }

    public abstract class CommonStatus
    {
        public TASK_STATUS taskStatus;
        public CommonStatus(TASK_STATUS taskStatus)
        {
            this.taskStatus = taskStatus;
        }
    }
    public class Open : CommonStatus, ITaskStatus
    {
        public Open() : base(TASK_STATUS.OPEN)
        {

        }
        public void nextStatus(Task task)
        {
            task.setCurrentStatus(new Inprogress());
        }
    }
    public class Inprogress : CommonStatus, ITaskStatus
    {
        public Inprogress() : base(TASK_STATUS.INPROGRESS)
        {

        }
        public void nextStatus(Task task)
        {
            task.setCurrentStatus(new Done());
        }
    }
    public class Done : CommonStatus, ITaskStatus
    {
        public Done() : base(TASK_STATUS.DONE)
        {

        }
        public void nextStatus(Task task)
        {
            task.setCurrentStatus(new Reopen());
        }
    }
    public class Reopen : CommonStatus, ITaskStatus
    {
        public Reopen() : base(TASK_STATUS.REOPEN)
        {

        }
        public void nextStatus(Task task)
        {
            task.setCurrentStatus(new Open());
        }
    }
}