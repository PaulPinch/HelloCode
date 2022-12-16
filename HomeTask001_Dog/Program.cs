int Count = 0, Mate = 2,
    firstFriendSpeed = 1,
    secondFriendSpeed = 2,
    dogSpeed = 5;
double Distance = 10000, tTime = 0;
    
while (Distance > 10)
{
    if (Mate == 2)
    {
        tTime = Distance / (secondFriendSpeed + dogSpeed);
        Mate = 1;
    }
    else
    {
        tTime = Distance / (firstFriendSpeed + dogSpeed);
        Mate = 2;
    }
    Distance = Distance - (firstFriendSpeed + secondFriendSpeed) * tTime;
    Count++;
}
System.Console.Write("Число пробежек собаки: ");
System.Console.WriteLine(Count);
