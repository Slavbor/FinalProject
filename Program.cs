using static System.Console;
Clear();
WriteLine();
WriteLine("    # ArrAy WiTh ElEmEnTs SiZe <=3 GeNeRaTiNg & PriNTiNg #");
WriteLine();

Write("Enter any strings separated by space: ");
string[] array = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)!;


PrintArray(LessEqual3Array(array));











string[] LessEqual3Array(string[] ArrayMethod)
{
    int summ = 0;
    foreach (var element in ArrayMethod)
    {
        if (element.Length <= 3)
        {
            summ +=1;
        }
    }
    var NewArray = new string[summ];
    int index = 0;
    foreach (var element in ArrayMethod)
    {
        if (element.Length <= 3)
        {
            NewArray[index] = element;
            index++;
        }
    }
    return NewArray;
}


void PrintArray(string[] inArray)
{
    Write("[");
    for (int i = 0; i < inArray.Length; i++)
    {
        Write($"{inArray[i]}");
        Write(i < inArray.Length - 1 ? ", " : "");
    }
    Write("]");
}