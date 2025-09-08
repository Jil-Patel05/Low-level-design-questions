Car Rental System:-

Requirements:-

1. We should be able to book car from start to end Date, StartTime, endTime City and state
2. There are many number of card depend upon size, and depend upon size or festival this cars price got changed
3. User which books the Car(Only when User is logged)
4. Petrol for car should be 100% when returning

Core Entities:-(Learn topic on dynamic pricing how it works)

1. User -> Username, FirstName -> Logged in User
2. Car -> CarNumber, Car size, Car price, carFuelCapacity, isCarBooked, CarBookedTo, CarBookteFrom, startTime, endTime, Location
3. CarRentalSystem -> which are managing all things
4. Payment -> we have to do payment at start -> We have to do fullPayment
5. BookedCarInfo -> user, CarNumber, isFullPaymentDone, payment that has been done.
6. Location -> Address of Cars where car is Located

DesignPatterns:-

1. Strategy Pattern for Payment -> User, Carnumber(Race conditions we have to handle)
2. ObserverPattern for notifying users on car Book

I am using type and city wise filtering of cars
