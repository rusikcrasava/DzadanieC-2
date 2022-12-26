Console.Clear();
    Console.Write("Введите цифрой день недели: ");
    int num = int.Parse(Console.ReadLine());
    if (num<1 || num>7)
    {
      Console.Write("Не существует такого дня недели");
    }
    else
    {
    if(6<=num && num <=7)
      {
    Console.Write("Да, это выходной, Уррррааа!");      
      }
      else
      {
    Console.Write("К сожалению, но отдохнуть не получиться :(");          
      }
    }
