int lenght = 4;
string[] array = new string[lenght];
Console.WriteLine("Введите 4 элемента первоначального массива.Каждый элемент вводится через ENTER: ");
array = FillArray(array);
// Делим массив от пользователя на 4 разных массива
string[] leftPartOrArray = GetLeftPartOfArray(array);
string[] rightPartOrArray = GetRightPartOfArray(array);
string[] firstElement = GetLeftPartOfArray(leftPartOrArray);
string[] secondElement = GetRightPartOfArray(leftPartOrArray);
string[] thirdElement = GetLeftPartOfArray(rightPartOrArray);
string[] fourthElement = GetRightPartOfArray(rightPartOrArray);

Console.WriteLine("[" + String.Join(", ", array) + "]");
Console.WriteLine("[" + String.Join(", ", firstElement) + "]");
Console.WriteLine("[" + String.Join(", ", secondElement) + "]");
Console.WriteLine("[" + String.Join(", ", thirdElement) + "]");
Console.WriteLine("[" + String.Join(", ", fourthElement) + "]");
// Метод заполнения массива от пользователя
string[] FillArray(string[] someArray)
{
    for (int i = 0; i < someArray.Length; i++)
    {
        someArray[i] = Console.ReadLine();
    }
    return someArray;
}
// Взятие левой части массива как отдельного нового массива
string[] GetLeftPartOfArray(string[] inArray)
{
    int mid = (inArray.Length + 1) / 2;
    string[] someArray = inArray[..mid];
    return someArray;
}
// Взятие правой части массива как отдельного нового массива
string[] GetRightPartOfArray(string[] inArray)
{
    int mid = (inArray.Length + 1) / 2;
    string[] someArray = inArray[mid..];
    return someArray;
}
