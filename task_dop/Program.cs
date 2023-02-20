// Представим банк, в котором алгоритм начисления
//  процента по вкладу зависит от суммы вклада.
//  На вход будет подаваться число (сумма вклада). 
// При значении меньше 100, будет начислено 5 %,
// если значение находится в диапазоне от ста 
// до двухсот — 7 %, если больше — 10 %. Отработав,
//  программа должна вывести общую сумму 
// с начисленными процентами.

Console.WriteLine("Вводим сумму вклада: ");
var contribution = Convert.ToInt32(Console.ReadLine());
if (contribution < 100)

 Console.WriteLine($"Первый вариант вклада {contribution  + contribution * 0.05} ");

    else if (contribution > 100 && contribution < 200)
     { 
   Console.WriteLine($"Второй вариант вклада {contribution  + contribution * 0.07} ");
     }

    else if(contribution > 200)
   {
   Console.WriteLine($"Третий вариант вклада {contribution  + contribution * 0.1} ");
   }

