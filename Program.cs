
string[] array = {"Den", "Samarkand", "Nickname", "23"};
int coun = array[1].Length; 
// int n = 1;
// string[] resultArray = new string[n];


void PrintArray (string[] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write(array[i]);
        Console.WriteLine();
    }
}

string SortArray (string[] array)
{
    int count = 3;
    int n = 1;
    string[] resultArray = new string[n];

    for(int i = 0; i < array.GetLength(0); i++)
    {
        if(array[i].Length <= count)
        {
            resultArray = array;
            Array.Resize(ref resultArray, n);
            n++;
        }

    }
    return resultArray[n]; 
}
SortArray(array);
PrintArray(array);
