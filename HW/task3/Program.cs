// Задайте  произвольную  строку.  Выясните, 
// является  ли  она  палиндромом.

Console.Clear();
Console.WriteLine("Введите слово для проверки является или оно палиндромом: ");
string str = Console.ReadLine();
char[] array = new char[str.Length];
char[] array2 = new char[str.Length];

for (int i = 0; i < str.Length; i++)
{
    array[i] = str[i];
}

for (int i = 0; i < str.Length; i++)
{
    array2[i] = array[i];
}

Array.Reverse(array2);

string str1 = string.Join(", ", array);
string str2 = string.Join(", ", array2);

if (str1 == str2)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}

// foreach (char item in array2)
// {
//     Console.Write(item);
// }

// if (array==array2)
// {
//     Console.WriteLine("Yes");
// }
// else
// {
//     Console.WriteLine("No");
// }

// for (int j = 0; j < array.Length / 2; j++)
// {
//     if (array[j] == array[array.Length - 1 - j])
//     {
//         Console.WriteLine("Да");
//     }

//     else
//     {
//         Console.WriteLine("Нет");
//     }
// }