// Доп. задание №2:
// Назовем число интересным, если в нем разность максимальной
//  и минимальной цифры равняется средней по величине цифре.
//   Напишите программу, которая определяет интересное число или нет.
//    Если число интересное, следует вывести – «Число интересное» 
//    иначе «Число неинтересное».
// -> 954 - число интересное, средняя цифра - 4, разница: 9 - 5 = 4.
// Средняя цифра - цифра(962-6, 23456 - средняя 4)

Console.WriteLine("Вводим число");
  int number = Convert.ToInt32(Console.ReadLine());

  int figure1 = number / 100;
  int figure2 = number % 10;
  int figure3 = ( number / 10) % 10;
  if (figure1 - figure2 == figure3 || figure2 -figure1 == figure3)
  {
  Console.Write("Интересное число");

  }
else
{
Console.Write("Число не интересное");
}

