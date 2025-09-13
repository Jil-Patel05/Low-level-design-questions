Stackoverflow:-

Requirements:-

1. User is able to add question(That question has some tag like angular, c#)
2. Another user can answer any question and also upvotes the response
3. Questioner can select any answer has useful
4. Question is only closed by community

Core Entities:-

1. User -> Username, trustnessscore, List<Responses>, List<Question>
2. Question -> Guid, string question, User, List<Responses>, isQuestionClosed
3. Response -> Guid, string response, Parent Guid, User, isAnswerSelectedByQuestioner
4. StackOverflow

Design Patterns:-

1. Singleton stackoverflow
2. Soriting technique on Response strategy
3. Observer pattern to notigy user on like, dislikes, or trustness score
