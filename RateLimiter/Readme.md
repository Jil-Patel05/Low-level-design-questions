Rate Limiter:-
https://leetcode.com/discuss/post/1616482/system-design-rate-limiter-by-anonymous_-5nu2/
https://bytebytego.com/courses/system-design-interview/design-a-rate-limiter

Requirements:-
System should support multiple rate limiting algo
Implement one rate limiting algo
Requirements may changes based on may be tracking IP or userId or anythig else

Core Entities:-
IAlgo -> leakyBucket, TokenBucket, FixedWindow, SlidingWindow logs
RateLimiter :- Which decide which algo to be used, and add user and drop request with proper message handling

Design Patterns:-
Strategy pattern for choosing algos
