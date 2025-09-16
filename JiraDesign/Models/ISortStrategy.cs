using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LLD_Q.JiraDesign.Models
{
    public interface ISortStrategy
    {
        public List<Task> sortTasks(List<Task> tasks);
    }

    public class SortByPriority : ISortStrategy
    {
        public List<Task> sortTasks(List<Task> tasks)
        {
            return tasks.OrderBy((elm) => elm.priority).ToList();
        }
    }
}