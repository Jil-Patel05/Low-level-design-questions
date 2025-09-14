using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LLD_Q.StackOverflowDesign.enums;

namespace LLD_Q.StackOverflowDesign.Observer
{
    public class ReputationManager
    {
        public readonly int RESPONSE_UPVOTE = 5;
        public readonly int RESPONSE_DOWNVOTE = -5;
        public readonly int QUESTION_UPVOTE = 2;
        public readonly int QUESTION_DOWNVOTE = -2;
        public readonly int TRUSTNESS_DOWNVOTE = -2;
        public readonly int TRUSTNESS_UPVOTE = -2;

        public void onPostEvent(Event eventObj)
        {
            User user = eventObj.user;
            switch (eventObj.eventType)
            {
                case EVENT_TYPE.TRUSTNESS_UPVOTE:
                    user.changeTrustNessScore(TRUSTNESS_UPVOTE, VOTE.UPVOTE);
                    break;
                case EVENT_TYPE.TRUSTNESS_DOWNVOTE:
                    user.changeTrustNessScore(TRUSTNESS_DOWNVOTE, VOTE.DOWNVOTE);
                    break;
                case EVENT_TYPE.RESPONSE_UPVOTE:
                    user.changeTrustNessScore(RESPONSE_DOWNVOTE, VOTE.UPVOTE);
                    break;
                case EVENT_TYPE.RESPONSE_DOWNVOTE:
                    user.changeTrustNessScore(RESPONSE_DOWNVOTE, VOTE.DOWNVOTE);
                    break;
                case EVENT_TYPE.QUESTION_UPVOTE:
                    user.changeTrustNessScore(QUESTION_UPVOTE, VOTE.UPVOTE);
                    break;
                case EVENT_TYPE.QUESTION_DOWNVOTE:
                    user.changeTrustNessScore(QUESTION_DOWNVOTE, VOTE.DOWNVOTE);
                    break;
                default:
                    break;
            }
            return;
        }
    }
}