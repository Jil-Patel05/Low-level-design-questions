using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LLD_Q.StackOverflowDesign.enums;

namespace LLD_Q.StackOverflowDesign
{
    public class User
    {
        public Guid guid;
        public string userName;
        public int trustNessScore;
        public IList<Question> questions;
        public IList<Response> responses;
        public object trustNessObject = new object();
        public User(string userName)
        {
            this.guid = Guid.NewGuid();
            this.userName = userName;
            this.trustNessScore = 0;
        }

        public void addUserQuestions(Question question)
        {
            this.questions.Add(question);
        }

        public void addUserResponses(Response response)
        {
            this.responses.Add(response);
        }

        public void changeTrustNessScore(int number, VOTE vote)
        {
            lock (trustNessObject)
            {
                if (vote == VOTE.UPVOTE)
                {
                    this.trustNessScore += number;
                }
                else
                {
                    this.trustNessScore -= number;
                }
            }
        }

        public void notifyUsingEmail()
        {
            Console.WriteLine($"User with {this.userName} is notified");
        }
    }
}