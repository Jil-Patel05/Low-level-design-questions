Task Management System Like Jira

Requirements:-

1. user should be able to make task for other and itself also.
2. User can update or delete the task
3. Each Task has some priority
4. Each task has STATUS
5. Each Ticket has some tags
6. Each Task type
7. You can add comments in each task
8. Each Task ticket has some history associated with it
9. Sort the task based on priority, Completeness
10. Task is transitioned from one state to another state in some order

Core Entities:-

1. User
2. Comment
3. Tag
4. Task

Design Patterns:-

1. Builder -> Task
2. Singleton -> TaskManager
3. observer pattern -> notify users
4. Strategy Pattern -> sort the tasl
