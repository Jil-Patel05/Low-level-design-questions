using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LLD_Q.StackOverflowDesign
{
    public class SortingStrategy
    {
        private ISortingStrategy sortingStrategy;
        public SortingStrategy(ISortingStrategy sortingStrategy)
        {
            this.sortingStrategy = sortingStrategy;
        }

        public void setSortingStrategy(ISortingStrategy sortingStrategy)
        {
            this.sortingStrategy = sortingStrategy;
        }

        public List<Response> sortResponse(IList<Response> reponses)
        {
            return this.sortingStrategy.sortResponse(reponses);
        }
    }
}