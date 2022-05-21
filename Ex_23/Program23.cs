// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int numA = Math.Abs(num);       // Чтобы отрицательные работали
if (numA > 20) Console.WriteLine("Давай поменьше, в экран не влазит");
else
{
    for (int i = 1; i <= numA; i++)
    {
        int res = i * i * i ;
        Console.Write(res+" ");
    }
}
// оформление как в примере. Куда тут таблицу пихать?