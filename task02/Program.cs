// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
//453 -> 12
//45 -> 9
//Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
//A = 3; B = 5 -> 243 (3⁵)
//A = 2; B = 3 -> 8


int GetN ()
{
    System.Console.WriteLine("Введите N ");
    return int.Parse(Console.ReadLine());
}


int Summ(int N)
{
    int sum = N%10;

    if (N >1)
    return Summ(N/10)+sum;
    return sum;
}

System.Console.WriteLine(Summ(GetN()));