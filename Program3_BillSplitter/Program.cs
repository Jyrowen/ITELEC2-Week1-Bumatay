int totalBill = 250;
int friends = 4;

// int / int drops the decimal part
int wholeShare = totalBill / friends;
// % gives what is left after dividing
int leftover = totalBill % friends;
// casting one number to double keeps the decimal part
double exactShare = (double)totalBill / friends;

Console.WriteLine($"Total bill: PHP {totalBill}");
Console.WriteLine($"Number of friends: {friends}");
Console.WriteLine($"Each pays (integer division): PHP {wholeShare}");
Console.WriteLine($"Leftover pesos: PHP {leftover}");
Console.WriteLine($"Each pays (exact): PHP {exactShare:F2}");