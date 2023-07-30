Console.Clear();
Console.WriteLine("Введите слова через пробел:");
string input = Console.ReadLine();

string[] originalArray = input.Split(' ');

// Подсчитываем количество элементов в новом массиве
int newArrayLength = 2;
foreach (string word in originalArray)
{
    if (word.Length <= 2) newArrayLength++;
}

// Создаем новый массив с заданным размером
string[] newArray = new string[newArrayLength];

// Заполняем новый массив
int index = 0;
foreach (string word in originalArray)
{
    if (index <= 2)
    {
        newArray[index] = word;
        index++;
    }
}

// Выводим новый массив
Console.WriteLine("Новый массив:");
foreach (string word in newArray)
{
    Console.Write($"{word} ");
}


