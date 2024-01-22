string[] CreateArray (int size) {

    string[] array = new string[size];
    
    for (int i = 0; i < size; i++){
        Console.Write("Введите элемент массива: ");
        array[i] = Console.ReadLine()!;
    }
    return array;
}

void ShowArray (string[] array){

    Console.Write("[");
    for(int i = 0; i < array.Length; i++){
        if (i == array.Length - 1) Console.Write($"'{array[i]}'");
        else Console.Write($"'{array[i]}', ");
    }
    Console.WriteLine("]");
}

string[] FilterArray (string[] inputArray, int maxLength){

    int lengthFilteredArray = 0;
    
    for (int i = 0; i < inputArray.Length; i++){
        if (inputArray[i].Length <= maxLength) lengthFilteredArray++;
    }

    string[] filteredArray = new string[lengthFilteredArray];
    int count = 0;

    for (int i = 0; i < inputArray.Length; i++){
        if (inputArray[i].Length <= maxLength){
            filteredArray[count] = inputArray[i];
            count++;
        }
    }
    return filteredArray;    
}

Console.Clear();
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

string[] array = CreateArray(size);

Console.Clear();
Console.Write($"Изначальный массив: ");
ShowArray(array);

Console.WriteLine();
string[] array2 = FilterArray(array, 3);
Console.Write($"Отфильтрованный массив: ");
ShowArray(array2);
