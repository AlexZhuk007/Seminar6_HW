﻿// Задайте строку, содержащую латинские буквы 
// в  обоих  регистрах.  Сформируйте  строку,  в  которой  все 
// заглавные  буквы  заменены  на  строчные. 

Console.Clear();
Console.WriteLine("Введите любое слово или фразу или символы на латинице: ");
string str = Console.ReadLine();
Console.WriteLine(str.ToLower());