 //Программа, на вход принимающая два числа (N),
 //а на выходе показывает какое число большее, а какое меньшее.

   int num;
   int num2;                                                                                                                                                        //Ввод данных

 // Ввод данных
  Console.Write("Введите число первое ");
  num = Convert.ToInt32(Console.ReadLine());

  Console.Write("Введите число второе ");
  num2= Convert.ToInt32(Console.ReadLine());
            bool max0 = num > num2;
            bool max1 = num == num2;
            bool max2 = num < num2;
 
 // Вычисление большего числа из двух
            if (max0)
            {
                Console.WriteLine("Число первое больше чем второе");
            }
            else if (max1)
            {
                Console.WriteLine("Числа первое и второе равны");
            }
            else if (max2)
            {
                Console.WriteLine("Число первое меньше чем второе");
            }
// Вводим заданые цифры, получаем результат.

