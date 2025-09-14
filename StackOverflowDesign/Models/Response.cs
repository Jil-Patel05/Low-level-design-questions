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
        public int likes;
        public bool isResponseSelectedByQuesioner;
        public Object likesObject = new Object(); // You can also use Interlock for atomic operations

        public Response(string response, User user) : base(response, user)
        {
            this.likes = 0;
            this.isResponseSelectedByQuesioner = false;
        }

        public void setResponseQuestion(Question question)
        {
            this.question = question;
        }

        public void changeLikes(VOTE vote)
        {
            if (vote == VOTE.UPVOTE)
            {
                lock (likesObject)
                {
                    this.likes++;
                }
            }
            else
            {
                lock (likesObject)
                {
                    this.likes--;
                }
            }
        }

        public void setResponseAsQuestionerResponse()
        {
            this.isResponseSelectedByQuesioner = true;
        }
    }
}