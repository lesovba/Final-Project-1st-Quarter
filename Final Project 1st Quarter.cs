/*Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.*/

PrintArray(BuildNewArray(CreateStringsAray()));

//Первый метод предназначен для создания нового массива путем ввода значений с клавиатуры. 
string[] CreateStringsAray()
{
    Console.Clear();
    //Сначала задаем размер массива. 
    Console.WriteLine("Введите размер массива");
    int size = int.Parse(Console.ReadLine());
    string[] array = new string[size];
    for (int i = 0; i < size; i++)
    {
        //Посторочно вводим элементы. 
        Console.WriteLine($"Введите {i} элемент массива");
        array[i] = Console.ReadLine();
    }
    Console.WriteLine();
    return array;
}

//Второй метод формирует новый массив из строк, длина которых меньше, либо равна трём символам.
string[] BuildNewArray(string[] arr)

{
    //Изначально задаем безопасную длину нового массива равную arr.Length, 
    //для того, чтобы в процессе не получить исключения "Index Out of Range".
    string[] newArray = new string[arr.Length];
    //Вводим переменную count для корректного получения индексов нового массива. 
    int count = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            //Записываем элементы в новый массив, согласно условию.
            //Чтобы не получить пустые значения в новом массиве, используем в качестве индекса count.
            newArray[count] = arr[i];
            count++;
        }
    }
    //Вероятнее всего, размер нового массива будет меньше изначального. 
    //Поэтому изменим его длину, обрезав справа с помощью метода Resize. 
    Array.Resize(ref newArray, count);
    Console.WriteLine($"Длина нового массива = {newArray.Length}");
    return newArray;
}

//Третий метод выводит полученный массив в консоль. 
void PrintArray(string[] newArr)
{
    for (int i = 0; i < newArr.Length; i++)
    {
        Console.Write($" {newArr[i]} ");
    }
    Console.WriteLine();
}