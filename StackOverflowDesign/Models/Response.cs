using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LLD_Q.StackOverflowDesign.enums;

namespace LLD_Q.StackOverflowDesign
{
    public class Response : Post
    {
        public Question question;
        public bool isResponseSelectedByQuesioner;

        public Response(string response, User user) : base(response, user)
        {
            this.isResponseSelectedByQuesioner = false;
        }

        public void setResponseQuestion(Question question)
        {
            this.question = question;
        }

        public void setResponseAsQuestionerResponse()
        {
            this.isResponseSelectedByQuesioner = true;
        }
    }
}