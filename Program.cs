
int[] FillArray(int size, int min, int max) 
{
    int[] filledArray = new int[size];
    for (int i = 0; i < filledArray.Length; i++){
        filledArray[i] = new Random().Next(min, max + 1);
    }
    return filledArray;
}



/*
Задача 34: Задайте массив заполненный случайными положительными 
трёхзначными числами. Напишите программу, которая покажет 
количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/

Console.Clear();
Console.WriteLine($"Задача 34. Количество чётных чисел в массиве:\n");
int[] randomarray = FillArray(20, 100, 1000);

Console.Write("    Получившийся массив: ");
void WriteArray(int[] array){
 for (int i = 0; i<array.Length; i++ ){
 Console.Write(array[i] + " ");
  }
}

int QuantityPositive(int[] array){
 int quantity = 0;
    for (int i = 0; i<array.Length; i++ ){
        if (array[i] % 2 == 1){}
        else quantity++;
    }
 return quantity;
}

WriteArray(randomarray);
Console.WriteLine();
int quantity = QuantityPositive(randomarray);
Console.WriteLine($"    Количество чётных чисел в массиве: {quantity} \n");


/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

Console.WriteLine($"Задача 36. Сумма элементов, стоящих на нечётных позициях:\n");

int RandomNumbers(int numberElements, int min, int max)
  {
  int[] randomNumbers = FillArray(numberElements, min, max);
  int sumElements = 0;
  Console.Write("    Получившийся массив: ");

    for (int i = 0; i <randomNumbers.Length; i++ ){
      randomNumbers[i] = new Random().Next(min, max);
      Console.Write(randomNumbers[i] + " ");
      if (i % 2 != 1){
        sumElements = sumElements + randomNumbers[i];
      }
    }
  return sumElements;
  }

int randomNumbers =  RandomNumbers(20, 100, 1000);

Console.WriteLine($"\n    Сумма элементов, стоящих на нечётных позициях: {randomNumbers}\n");

/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу 
между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/

Console.WriteLine($"Задача 38. Найдите разницу между максимальным и минимальным элементов массива из вещественных чисел:\n");

int[] arrayRealNumbers = FillArray(10, 1, 100);
Console.Write("    Получившийся массив: ");
WriteArray(arrayRealNumbers);

double maxNumber = arrayRealNumbers[0];
double minNumber = arrayRealNumbers[0];

  for (int i = 1; i < arrayRealNumbers.Length; i++)
  {
    if (maxNumber < arrayRealNumbers[i]){
      maxNumber = arrayRealNumbers[i];
    }
    else if (minNumber > arrayRealNumbers[i]){
      minNumber = arrayRealNumbers[i];
    }
  }

  double decision = maxNumber - minNumber;
  Console.WriteLine($"\n    разница между между максимальным ({maxNumber}) и минимальным({minNumber}) элементами: {decision}\n");

/*
Задайте одномерный массив, заполненный случайными числами. 
Из входного массива сформируйте массив с чётными и массив с 
нечётными значениями элементов входного массива. Найдите 
ср. арифметическое из полученных значений элементов массивов и 
выведите результат сравнения средних арифметических.

[1,2,3,4] -> средн. арифм. значений элементов массива с 
чётными числами > средн. арифм. значений элементов с нечётными числами
[2,3,5,7] -> средн. арифм. массива значений элементов с 
нечётными числами > средн. арифм. значений элементов с чётными числами
[1,2,5,4] -> средн. арифм. значений элементов массива с 
нечётными числами = средн. арифм. значений элементов с чётными числами
*/

/*
Задайте одномерный массив из N элементов, заполненный случайными 
числами. Необходимо определить, в какой последовательности заданы 
элементы массива: по возрастанию, по убыванию, хаотично, или все 
элементы одинаковы.

[1,2,3,4] -> по возрастанию
[4,3,2,1] -> по убыванию
[4,2,3,1] -> хаотично
[1,1,1,1] -> все элементы равны
*/

