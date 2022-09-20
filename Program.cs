// Создаётся основной массив array:
string[] array = {"Den", "Samarkand", "456", "Nickname", "23", ")&"};
/* Объявляется переменная elementsNumber для подсчёта 
общего кол-ва элементов < или = 3:*/
int elementsNumber = 0;
// Создаётся метод SortArray для поиска нужных элементов,
// и записи их в нужный массив:
string[] SortArray (string[] array)
{
    // Объявляется переменная count с нужным нам кол-вом символов
    int count = 3;
    // Создаётся новый массив для записи в него результатов отбора элементов:
    string[] newArray = new string[array.Length];
    
    for(int i = 0; i < array.GetLength(0); i++)
    {
        int charCount = array[i].Length; 
        if(charCount <= count)
        {
            newArray[i] = array[i];
            elementsNumber++; 
        }

    }
    if (elementsNumber == 0)
    {
        Console.WriteLine($"Количество элементов меньше или равно трём: {elementsNumber}");
    }
    else 
    {
        Console.WriteLine($"Количество элементов меньше или равно трём: {elementsNumber}");
    }
    return newArray; 
}

void PrintArray (string[] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write(array[i]);
        Console.WriteLine();
    }
}

string[] resultArray = SortArray(array);
PrintArray(resultArray);
