Logging system

Requirements:-

1. We have to log multiple logs on file, based on LOG TYPE(INFO, WARNING, DEBUG, ERROR)
2. We have to log this messages on some file, Which is stored in any platform like AWS S3

Core entities :-
Log -> message, log type(Time [TYPE] message -- format for logging)

Design Patterns :-
Singleton for logging
Chain of responsibilty
