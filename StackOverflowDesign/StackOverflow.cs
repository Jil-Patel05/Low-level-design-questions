using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LLD_Q.StackOverflowDesign
{
    public class StackOverflow
    {
        private IList<User> users;
        private SortingStrategy strategy;
        private IList<Question> questions;
        private IList<Response> responses;
        private Question? currentQuestion;

        public StackOverflow()
        {
            this.users = new List<User>();
            this.questions = new List<Question>();
            this.responses = new List<Response>();
            this.strategy = new SortingStrategy(new LikesSorting());
        }

        public void addQuestion(string userQuestion, User user)
        {
            Question question = new Question(userQuestion, user);
            this.questions.Add(question);
        }
        public void seeAllRelavantQuestion()
        {
            foreach (Question item in questions)
            {
                Console.WriteLine($"Question -> {item.question} and for response type -> {item.guid}");
            }
        }
        public void addResponse(string userResponse, User user, Guid guid)
        {
            this.currentQuestion = this.questions.Where(q => q.guid == guid).FirstOrDefault();
            Response response = new Response(userResponse, user);
            response.setResponseQuestion(currentQuestion);
            this.responses.Add(response);
        }

        public void seeQuestionsAndResponses()
        {
            foreach (Question item in questions)
            {
                Console.WriteLine($"Question -> {item.question}");
                IList<Response>? questionResponse = this.questions.FirstOrDefault(q => q.guid == item.guid)?.responses;
                List<Response> sortedResponses = this.strategy.sortResponse(questionResponse);
                foreach (Response response in sortedResponses)
                {
                    Console.WriteLine($"Response for question is -> {response.response} and for response vote -> {response.guid} and likes is {response.likes}");
                }
            }
        }

        public void likeOrDisLikeResponse(Guid guid, bool isLike)
        {
            Response? response = this.currentQuestion?.responses.Where(res => res.guid == guid).FirstOrDefault();
            if (response != null)
            {
                // Notify Response posting user about this action
                if (isLike)
                {
                    response.increaseLikes();
                }
                else
                {
                    response.decreaseLikes();
                }
                // Or u can use Kafka to transfer this whole thing as async
                // Make sure you are using deadletter queue as well
                response.user.notifyUsingEmail();
            }
        }
    }
}