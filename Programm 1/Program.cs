int a;
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


    a = Convert.ToInt32(Console.ReadLine());
    switch (a)
    {
        case 1:
            Console.WriteLine("Введите два числа, которые хотите сложить");
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(b + c);
            break;
        case 2:
            Console.WriteLine("Введите два числа, разницу которых вы хотите узнать");
            int z = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(z - m);
            break;
        case 3:
            Console.WriteLine("Введите два числа, которые хотите умножить");
            int t = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(t * y);
            break;
        case 4:
            Console.WriteLine("Введите два числа, которые хотите разделить");
            int P = Convert.ToInt32(Console.ReadLine());
            int u = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(P / u);
            break;
        case 5:
            Console.WriteLine("Напишите число, а затем степень в которую вы хотите возвести данное число");
            int G = Convert.ToInt32(Console.ReadLine());
            int D = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{(long)Math.Pow(G, D):N0}");
            break;
        case 6:
            Console.WriteLine("Введите число, квадратный корень которого вы хотите найти");
            int M = Convert.ToInt32(Math.Sqrt(5.25));
            Console.WriteLine(M);
            break;
        case 7:
            Console.WriteLine("Введите число 1% которого вы хотите узнать");
            int C = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(C *0.01);
            break;
        case 8:
            Console.WriteLine("Введите число факториал которого вы хотите найти");
            int n = Convert.ToInt32(Console.ReadLine());
            int factorial = 1;  
            for (int i = 2; i <= n; i++) 
            {
                factorial = factorial * i;
            }
            Console.WriteLine(factorial);
            break; 
        case 9:
            Console.WriteLine("Завершение программы.");
            break;
    }
} while (a != 9);
