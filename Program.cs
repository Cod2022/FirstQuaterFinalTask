
string[] array = {"Den", "Samarkand", "Nickname", "23"};

void PrintArray (string[] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write(array[i]);
        Console.WriteLine();
    }
}


PrintArray(array);