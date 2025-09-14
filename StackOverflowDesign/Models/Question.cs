using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LLD_Q.StackOverflowDesign.enums;

namespace LLD_Q.StackOverflowDesign
{
    public class Question : Post
    {
        public bool isQuestionOpen;
        public int votes;
        public IList<Response> responses;
        public Object votesObject = new Object(); // You can also use Interlock for atomic operations

        public Question(string question, User user) : base(question, user)
        {
            this.isQuestionOpen = true;
            responses = new List<Response>();
        }

        public void closeQuestion()
        {
            this.isQuestionOpen = false;
        }

        public void addResponse(Response response)
        {
            this.responses.Add(response);
        }

        public void changeVotes(VOTE vote)
        {
            if (vote == VOTE.UPVOTE)
            {
                lock (votesObject)
                {
                    this.votes++;
                }
            }
            else
            {
                lock (votesObject)
                {
                    this.votes--;
                }
            }
        }
    }
}