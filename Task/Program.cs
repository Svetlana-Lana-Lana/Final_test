// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше
// либо равна трем символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры
// ["Hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []

string [] array =["1234", "1567", "-2", "computer science"];
string [] CheckArray(string [] array)
{
    int new_array_size = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
            {
                new_array_size++;
            }
    }
    int new_array_index = 0;
    string [] new_array = new string[new_array_size];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
            {
                new_array[new_array_index] = array[i];
                new_array_index++;
            }
    }
    return new_array;
}
void ShowArray(string [] new_array)
{
    foreach(string item in new_array)
    {
        Console.Write(item+" ");
    }
    Console.WriteLine();
}
string[] new_array = CheckArray(array);
ShowArray(new_array);
