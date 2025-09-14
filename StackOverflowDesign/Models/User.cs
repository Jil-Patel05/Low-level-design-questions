using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LLD_Q.StackOverflowDesign
{
    public class User
    {
        public string userName;
        public int trustNessScore;
        public IList<Question> questions;
        public IList<Response> responses;
        public User(string userName)
        {
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

        public void increaseUserTrustNessScore()
        {
            this.trustNessScore++;
        }
        public void decreaseUserTrustNessScore()
        {
            this.trustNessScore--;
        }

        public void notifyUsingEmail()
        {
            Console.WriteLine($"User with {this.userName} is notified");
        }
    }
}