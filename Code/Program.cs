int lenght = 4;
string[] array = new string[lenght];
Console.WriteLine("Введите 4 элемента первоначального массива.Каждый элемент вводится через ENTER: ");
array = FillArray(array);
// Метод заполнения массива от пользователя
string[] FillArray(string[] someArray)
{
    for (int i = 0; i < someArray.Length; i++)
    {
        someArray[i] = Console.ReadLine();
    }
    return someArray;
}
Console.Write("[" + String.Join(", ", array) + "]");