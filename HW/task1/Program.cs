// Задайте двумерный массив символов (тип char [,]). 
//Создать строку из символов этого массива. 

char[,] matrixchar = { 
                        {'a','b','c'},
                        {'d','e','f'}
                      };

string str = "";

for (int i = 0; i < matrixchar.GetLength(0); i++)
{
    for (int j = 0; j < matrixchar.GetLength(1); j++)
    {
        str = str + matrixchar[i, j];
        
        // Console.Write($"-{matrix[i, j]}-");
        // Console.Write("\t");
    }
    
}    
Console.WriteLine(str);