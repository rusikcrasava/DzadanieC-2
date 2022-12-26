    Console.Clear();
    Console.Write("Введите число: ");
    int num = int.Parse(Console.ReadLine());
    int num1 = num;
    int n=0;
    while (num1>0)
      {
        num1 /=10;
        n++;
      }
    Console.Write("Третья цифра вашего числа: ");
    int x=Convert.ToInt32(Math.Pow(10,n-3));
    if (n<3)
      {
    Console.Write("отсутствует");        
      }
    else
      {
    Console.Write($"{(num/x)%10}");
      }
