Console.Clear();
int n = new Random().Next(); // for getting the random number
Console.WriteLine("the random casual number is: " + n); // print the random number into display 
    for (int i = 0; n > 1000; i++) // make a circle for getting a third-digit number
        {
            n = n / 10; // cut the Number till third-digit number
        }
    if (n > 100 && n < 1000) // condition under witch we find the third Number
    {
      int ThirdNumber = n % 10; // division without remainder, for finding the third number
      Console.WriteLine("Third digit of the random number is: " + ThirdNumber); // printing the third Number
    }
    else if (n < 100) // the second conditions in a case the number has no a third dozens
     {
        Console.WriteLine("The random number has no a third dozens "); // printing phrase: The random number has no a third dozens
     }

