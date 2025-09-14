using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LLD_Q.StackOverflowDesign
{
    public interface ISortingStrategy
    {
        public List<Response> sortResponse(IList<Response> responses);
    }

    public class LikesSorting : ISortingStrategy
    {
        public List<Response> sortResponse(IList<Response> responses)
        {
            List<Response> sortedResponse = responses.OrderBy(elm => elm.votes).ToList();
            return sortedResponse;
        }
    }
    public class UserTrustNess : ISortingStrategy
    {
        public List<Response> sortResponse(IList<Response> responses)
        {
            List<Response> sortedResponse = responses.OrderBy(elm => elm.user.trustNessScore).ToList();
            return sortedResponse;
        }
    }
}