
static int SearchIndex(int[] array, int value) // Метод поиска индекса дублирует метод класса Array.IndexOf
{
    for(int i = 0;i < array.Length; i++) // Перебор массива
    {
        if(value == array[i]) // сравнение значения заданого для поиска
        {
            return i; // возвращения индекса нужного значения 
        }
    }

    return -1; // если нет соответсвии возвращает -1 как в методе IndexOf
}

// метод заполнения массива рандомными цифрами
    static int[] GetRandomArray(uint lenght, int minValue, int maxValue)
{ 
    int[] myArray = new int[lenght]; // инициализация массива с размером заданым пользователем

    Random random = new Random();

    for(int i = 0; i < myArray.Length; i++) // цикл для перебора массива
    {
        myArray[i] = random.Next(minValue, maxValue); // заполнение массива рандомными цыйфрами в диапозоне указаный пользоватлем
    }

    return myArray; // вохвращаем готовый массив с рандомными числами
}


// инициализация массива с методом заполнения рандомными цифрами
int[] arr = GetRandomArray(10, -20, 10); // (длинна массива, мин. знач., макю знач. диапазона)

int result = SearchIndex(arr, 5); // Поиск индекса по методу SearchIndex

Console.WriteLine(result); 

// Console.WriteLine(Array.IndexOf(arr, 5)); // Поиск индекса по методу IndexOf

Console.ReadLine();