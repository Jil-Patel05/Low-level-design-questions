using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LLD_Q.StackOverflowDesign.enums;
using LLD_Q.StackOverflowDesign.Observer;

namespace LLD_Q.StackOverflowDesign
{
    public class Post
    {
        public Guid guid;
        public string body;
        public User user;
        public int votes;
        public object voteLock = new object();
        public ConcurrentDictionary<Guid, VOTE> userVotes = new ConcurrentDictionary<Guid, VOTE>();
        private ReputationManager manager = new ReputationManager();

        public Post(string body, User user)
        {
            this.body = body;
            this.user = user;
            this.guid = Guid.NewGuid();
        }

        public void NotifyObservers(Event eventObj)
        {
            manager.onPostEvent(eventObj);
        }

        public void vote(User user, VOTE vote)
        {
            lock (voteLock)
            {
                Guid userId = user.guid;
                if (userVotes.TryGetValue(userId, out VOTE existingVote) && existingVote == vote)
                    return; // Already voted

                int scoreChange = 0;
                if (userVotes.ContainsKey(userId)) // User is changing their vote
                {
                    scoreChange = (vote == VOTE.UPVOTE) ? 2 : -2;
                }
                else // New vote
                {
                    scoreChange = (vote == VOTE.UPVOTE) ? 1 : -1;
                }

                userVotes[userId] = vote;
                votes += scoreChange;

                EVENT_TYPE eventType;
                if (this is Question)
                {
                    eventType = (vote == VOTE.UPVOTE) ? EVENT_TYPE.QUESTION_UPVOTE : EVENT_TYPE.QUESTION_DOWNVOTE;
                }
                else
                {
                    eventType = (vote == VOTE.UPVOTE) ? EVENT_TYPE.RESPONSE_UPVOTE : EVENT_TYPE.RESPONSE_DOWNVOTE;
                }
                NotifyObservers(new Event(eventType, user, vote));
            }
        }
    }
}