int n = new Random().Next(100,1000);
Console.WriteLine("Random number n = "+ n);
int x1 = n / 100;
int x3 = n % 10;
int y = x1*10 + x3;
Console.WriteLine("the new number is consisted of the fist unit of random number and the third unit of one is: " + y);

