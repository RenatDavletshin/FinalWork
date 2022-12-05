// Написать программу, которая из имеющегося массива строк формирует 
// массив из строк, длина которых меньше либо равна три символа.


Console.WriteLine("Введите любые пять слов или цифр через Enter:");
string[] array1 = new string[5];
for (int i = 0; i < array1.Length; i++)
{
    array1[i] = Console.ReadLine();
}

string[] array2 = new string[array1.Length];

FillSecondArray(array1, array2);
PrintArray(array2);

void FillSecondArray(string[] array1, string[] array2)
{
    int i = 0;
    for (int j = 0; j < array1.Length; j++)
    {
        if (array1[j].Length <= 3)
            {
                array2[i] = array1[j];
                i++;
            }
    }
}

void PrintArray(string[] array)
{
    Console.WriteLine("Вывод массива из строк, длина которых меньше либо равна 3 символам:");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}