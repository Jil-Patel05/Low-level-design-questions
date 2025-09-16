using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LLD_Q.JiraDesign.Models
{
    public class SortStrategy
    {
        public ISortStrategy strategy;

        public SortStrategy(ISortStrategy strategy)
        {
            this.strategy = strategy;
        }

        public void setStrategy(ISortStrategy strategy)
        {
            this.strategy = strategy;
        }

        public List<Task> sort(List<Task> tasks)
        {
            return this.strategy.sortTasks(tasks);
        }
    }
}