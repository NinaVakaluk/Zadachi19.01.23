/*Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел строго больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2   1, -7, 567, 89, 223-> 4
Для строки можно использовать данный метод string[] numS = stringArray.Split(' ', StringSplitOptions.RemoveEmptyEntries)(пользователь вводит в консоли 
числа через пробел и они формируют строку)*/

Console.WriteLine("Введи число:");
string numS = (Console.ReadLine()!);
string[] stringArray = numS.Split(' ', StringSplitOptions.RemoveEmptyEntries);

int[] newArray=new int[stringArray.Length];
for (int i=0;i<stringArray.Length;i++)
{
  newArray[i]=Convert.ToInt32(stringArray[i]);
} 
Console.WriteLine($"[{String.Join(",", newArray)}]");
Console.WriteLine($"Количество чисел больше 0 -> {Quantity(newArray)}");


int Quantity(int[] numbers)
{

   
    int result = 0;
    foreach (int N in numbers)
    {
        if (N > 0)
        {
            result++;
        }
    }
    return result;
}



