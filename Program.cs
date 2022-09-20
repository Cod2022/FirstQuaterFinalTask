
string[] array = {"Den", "Samarkand", "Nickname", "23"};

void PrintArray (string[] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write(array[i]);
        Console.WriteLine();
    }
}

string[] SortArray (string[] array)
{
    int count = 3;
    string[] resultArray = new string[array.Length];

    for(int i = 0; i < array.GetLength(0); i++)
    {
        if(array[i].Length <= count)
        {
            resultArray[i] = array[i];
        }

    }
    return resultArray; 
}
SortArray(array);
PrintArray(array);
