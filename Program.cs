//1. Получение первоначальных строковых значений с консольного ввода

string GetUserString()
{
    Console.WriteLine("Enter your string data in one line , with 1 space as the separator:");
    string cons_input = Console.ReadLine();
    return cons_input;
}

// 2. Создание массива строк из полученных значений

string[] StringToArray(string line)
{
    int arr_size = 1;
    for (int i = 0; i < line.Length; i++)
    {
        if (line[i] == ' ') arr_size++;
    }

    string[] word_array = new string[arr_size];
    int line_index = 0;
    for (int arr_index = 0; arr_index< arr_size; arr_index++)
    {
        
        while (line[line_index] != ' ' )
        {
            word_array[arr_index] += line[line_index];
            line_index++;
            if (line_index == line.Length) break;
        }
        line_index++;
    }

    return word_array;
}

//3. Подсчет количества элементов с длиной меньше 4 символов для выяснения размера конечного массива.

int CountShortWords(string[] word_array, int maxString = 3)
{
    int short_count = 0;
    for (int i = 0; i < word_array.GetLength(0); i++)
    {
        if (word_array[i].Length <= maxString) short_count ++;
    }
    // Console.WriteLine();
    // Console.WriteLine($"Found {short_count} words with less or equal to {maxString} symbols.");
    return short_count;
}

//4. Создание конечного массива и запись всех элементов длиной меньше 4 символов . 

string[] FilterShortToArray(string[] initArray, int maxString = 1)
{
    int size = CountShortWords(initArray, maxString);
    string[] resultArray= new string[size];
    int k=0;
    
    for (int i = 0; i < initArray.GetLength(0); i++)
    {
        if (initArray[i].Length <= maxString)
        {
            resultArray[k] = initArray[i];
            k++;
        }
        
    }
    return resultArray;

}

//5. Вывод массива в консоль для проверки

void ShowStrArray(string[] printed_array)
{
    int size = printed_array.GetLength(0);
    for (int i = 0; i < size; i++)
    {
        if (i != size - 1)
        {
            Console.Write($"'{printed_array[i]}',");
        }
        else Console.Write($"'{printed_array[i]}'");

    }
}


//Запуск наших методов для решения задачи.


Console.Clear();
string[] start_array = StringToArray(GetUserString());
string[] end_array = FilterShortToArray(start_array, 3);

Console.Write("[");
ShowStrArray(start_array);
Console.Write("] ->[");
ShowStrArray(end_array);
Console.WriteLine("]");


//Проверка по примерам в условии

/*
// string[] start_array = {"hello","2","world",":-)"};
// string[] start_array = {"1234","1567","-2","computer science"};
string[] start_array = {"Russia","Denmark","Kazan"};

string[] end_array = FilterShortToArray(start_array);

Console.Write("[");
ShowStrArray(start_array);
Console.Write("] ->[");
ShowStrArray(end_array);
Console.WriteLine("]");
*/




