﻿Console.Clear();
int i = 0;
int n = Convert.ToInt32(Console.ReadLine());
  int max1 = n;
  int max2 = n;
  while (n != 0)
 {
      n  = Convert.ToInt32(Console.ReadLine());  
             if (n > max1)
            {   
             max2 = max1;
             max1 = n;
            }
            else if (n> max2 && n < max1)
            {
              max2 = n;
            }
       i = i + 1;
 }
    Console.WriteLine("end");
    Console.WriteLine("количество вводов равно: " + i);
    Console.WriteLine("первый максимум равен: " + max1);      
    Console.WriteLine("ВТОРОЙ МАКСИМУМ РАВЕН: " + max2); 