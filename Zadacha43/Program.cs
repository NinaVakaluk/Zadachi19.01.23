//Написать программу, которая на вход принимает массив из любого количества элементов (не менее 6)в промежутке от 0 до 100, а на выходе выводит 
//этот же массив, но отсортированный по возрастанию(от меньшего числа к большему).

int[] Array = GetArray(6);
Console.WriteLine($"[{String.Join(",", Array)}]");
SortedArray(Array);
Console.WriteLine($"[{String.Join(",", Array)}]");


int[] GetArray(int size)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(0,100);
    }
    return res;
}
void SortedArray(int[] number)
{
   
int temp;

for (int k=0;k<number.Length-1;k++)
{
    for (int j=k+1;j<number.Length;j++)
    {
        if (number[k]>number[j])
        {
            temp=number[k];
            number[k]=number[j];
            number[j]=temp;
        }
    }
}

 }

