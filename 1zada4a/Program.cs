Console.Clear();
    Console.Write("Напишите далее трехзначное число: ");
    int number = int.Parse(Console.ReadLine());
    Console.Write($"Вторая цифра вашего числа: {(number/10)%10}");
