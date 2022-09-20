
string[] array = {"Den", "Samarkand", "456", "Nickname", "23", ")&"};

int elementsNumber = 0; 


string[] SortArray (string[] array)
{
    int count = 3;
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
