//Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
//Решение:
//Конвертируем введенную пользователем строку в массив слов.
string[] ReadLineToArray(string value)
{
    try
    {
        Console.Write($"{value}: ");
        string[] array = Console.ReadLine()!.Split().ToArray();
        return array;
    }
    catch
    {
        string[] array = {""};
        return array;
    }
}
//Функция принимает массив слов и искомую длину слов (по дефолту 3). Отсеивает слова
string[] ConvertArrayForTask1(string[] userArray, int maxLength = 3)
{
    string[] newArray = new string[0];
    for (int i = 0; i < userArray.Length; i++)
    {
        if (userArray[i].Length <= maxLength)
        {
            Array.Resize(ref newArray, newArray.Length + 1);
            newArray[newArray.Length - 1] = userArray[i];
        }
    }
    return newArray;
}
