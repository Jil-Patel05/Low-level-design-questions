using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LLD_Q.StackOverflowDesign
{
    public class Question
    {
        public Guid guid;
        public string question;
        public User user;
        public bool isQuestionOpen;
        public IList<Response> responses;

        public Question(string question, User user)
        {
            this.question = question;
            this.user = user;
            this.isQuestionOpen = true;
            this.guid = Guid.NewGuid();
        }

        public void closeQuestion()
        {
            this.isQuestionOpen = false;
        }

        public void addResponse(Response response)
        {
            this.responses.Add(response);
        }
    }
}