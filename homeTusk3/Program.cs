Console.WriteLine("input the number from 1 to 7");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("You input the number: " + n);
int Monday = 1;
int Tuesday =2;
int Wednesday =3;
int Thursday =4;
int Friday =5;
int Saturday =6;
int Sunday =7;
if (n < 1 || n > 7)
{
    Console.WriteLine("You entered wrong number");
}
else if (n == Saturday)
{
    Console.WriteLine("You entered the number: " + n + " this number corresponds to a weekend");
}
else if (n == Sunday)
{
Console.WriteLine("You entered the number: " + n + " this number corresponds to a weekend");
}
else 
{
    Console.WriteLine("You entered the number: " + n + " this number corresponds to the working day");
}