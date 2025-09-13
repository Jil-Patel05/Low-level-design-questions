using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LLD_Q.StackOverflowDesign
{
    public class Response
    {
        public Guid guid;
        public Question question;
        public string response;
        public User user;
        public int likes;
        public bool isResponseSelectedByQuesioner;

        public Response(string response, User user)
        {
            this.guid = Guid.NewGuid();
            this.response = response;
            this.user = user;
            this.likes = 0;
            this.isResponseSelectedByQuesioner = false;
        }

        public void setResponseQuestion(Question question)
        {
            this.question = question;
        }

        public void increaseLikes()
        {
            this.likes++;
        }
        public void decreaseLikes()
        {
            this.likes--;
        }

        public void setResponseAsQuestionerResponse()
        {
            this.isResponseSelectedByQuesioner = true;
        }
    }
}