//1. Получение первоначальных строковых значений с консольного ввода

string GetUserString()
{
    Console.WriteLine("Enter your string data in one line , with spaces as separators:");
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

void ShowStrArray(string[] printed_array)
{
    int size = printed_array.GetLength(0);
    for (int i = 0; i < size; i++)
    {
        if (i != size - 1)
        {
            Console.Write($"{printed_array[i]},");
        }
        else Console.Write($"{printed_array[i]}");

    }
}

//3. Подсчет количества элементов с длиной меньше 4 символов для выяснения размера конечного массива.

int CountShortWords(string[] word_array, int maxString = 3)
{
    int short_count = 0;
    for (int i = 0; i < word_array.GetLength(0); i++)
    {
        if (word_array[i].Length <= maxString) short_count ++;
    }
    Console.WriteLine();
    Console.WriteLine($"Found {short_count} words with less or equal to {maxString} symbols.");
    return short_count;
}

//4. Создание конечного массива и запись всех элементов длиной меньше 4 символов . 



string[] start_array = StringToArray(GetUserString());
//ShowStrArray(start_array);
CountShortWords(start_array);



