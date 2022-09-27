int oper;
do
{
    Console.WriteLine("Выберите какую операцию вы хотите сделать: ");
    Console.WriteLine("\r\n1. Сложить 2 числа\r\n" +
                      "2. Вычесть первое из второго \r\n" +
                      "3. Перемножить два числа\r\n" +
                      "4. Разделить первое на второе\r\n" +
                      "5. Возвести в степень N первое число\r\n" +
                      "6. Найти квадратный корень из числа\r\n" +
                      "7. Найти 1 процент от числа\r\n" +
                      "8. Найти факториал из числа\r\n" +
                      "9. Выйти из программы\r\n");


    oper = Convert.ToInt32(Console.ReadLine());
    switch (oper)
    {
        case 1:
            Console.WriteLine("Напишите два числа");
            int ab1 = Convert.ToInt32(Console.ReadLine());
            int ab2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(ab1 + ab2);
            break;
        case 2:
            Console.WriteLine("Напишите два числа");
            int ab3 = Convert.ToInt32(Console.ReadLine());
            int ab4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(ab4 - ab3);
            break;
        case 3:
            Console.WriteLine("Напишите два числа");
            int ab5 = Convert.ToInt32(Console.ReadLine());
            int ab6 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(ab5 * ab6);
            break;
        case 4:
            Console.WriteLine("Напишите два числа");
            int ab7 = Convert.ToInt32(Console.ReadLine());
            int ab8 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(ab7 / ab8);
            break;
        case 5:
            Console.WriteLine("Напишите два числа");
            int ab9 = Convert.ToInt32(Console.ReadLine());
            int ab10 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{ab9}^{ab10} = {(long)Math.Pow(ab9, ab10):N0} (0x{(long)Math.Pow(ab9, ab10):X})");
            break;
        case 6:
            Console.WriteLine("Напишите число");
            int ab11 = Convert.ToInt32(Math.Sqrt(5.25));
            Console.WriteLine(ab11);
            break;
        case 7:
            Console.WriteLine("Напишите число");
            int ab12 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(ab12 % 1);
            break;
        case 8:
            Console.WriteLine("Напишите число");
            int ab13 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Не знаю как найти интеграл");
            break; 
        case 9:
            Console.WriteLine("Завершение программы.");
            break;
    }
} while (oper != 9);
