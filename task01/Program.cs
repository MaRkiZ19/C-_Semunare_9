// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
//N = 5 -> "1, 2, 3, 4, 5"
//N = 6 -> "1, 2, 3, 4, 5, 6"

int GetN ()
{
    System.Console.WriteLine("Введите N ");
    return int.Parse(Console.ReadLine());
}

int N = GetN();
System.Console.WriteLine();
void Numbers(int N)
{
    if(N >0 ) 
    {
        Numbers(N-1);
        System.Console.WriteLine(N);
    }
}

Numbers(N);