void FirstTask()
{
    //  Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
    System.Console.WriteLine("Введите число а:");
    int a = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine("Введите число б:");
    int b = Convert.ToInt32(Console.ReadLine());

    if (a > b)
    {
        System.Console.WriteLine(string.Concat("Число а (", a, ") больше числа б (", b, ")"));
    }
    else if (b > a)
    {
       System.Console.WriteLine(string.Concat("Число б (", b, ") больше числа а (", a, ")")); 
    }
    else
    {
        System.Console.WriteLine(string.Concat("Числа а и б равны (", b, ")"));   
    }
}

void SecondTask()
{
    System.Console.WriteLine("Введите 3 числа:");
    int a = Convert.ToInt32(Console.ReadLine());
    int b = Convert.ToInt32(Console.ReadLine());
    int c = Convert.ToInt32(Console.ReadLine());
    int max = Math.Max(a, Math.Max(b, c));

    System.Console.WriteLine(string.Concat("Максимальное число - ", max));
}

void ThirdTask()
{
    System.Console.Write("Введите число: ");
    int num = Convert.ToInt32(Console.ReadLine());

    if (num % 2 == 0)
    {
        System.Console.WriteLine("Число чётное");
    }
    else
    {
        System.Console.WriteLine("Число нечётное");
    }
}

void FourthTask()
{
    System.Console.Write("Введите число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    if(num > 1000)
    {
        System.Console.WriteLine("Да ну нахрен!");
    }
    else
    {
        for(int i=2; i<=num; i+=2)
        {       
            System.Console.Write(i + " ");
        }
    }
    
}

System.Console.WriteLine("Введите номер проверяемой задачи от 1 до 4, где:\n1 - узнать, какое число больше, а какое меньше\n2 - узнать максимальное из трёх чисел\n3 - узнать, чётное ли число\n4 - узнать все чётные числа от 1 до N");
System.Console.Write("Проверить задачу №");
int task = Convert.ToInt32(Console.ReadLine());

switch (task)
{
    case 1:
        FirstTask();
        break;
    case 2:
        SecondTask();
        break;
    case 3:
        ThirdTask();
        break;
    case 4:
        FourthTask();
        break;
    default:
        System.Console.WriteLine("Задачи с таким номером не существует");
        break;
}
